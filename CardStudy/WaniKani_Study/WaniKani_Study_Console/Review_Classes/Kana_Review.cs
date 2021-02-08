using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using WaniKani_Study_Console;
using WaniKani_Study.Object_Classes;



namespace WaniKani_Study.Review_Classes
{



    public class Kana_Review : IReview
    {


        #region Constructors
        public Kana_Review()
        {
        }


        public Kana_Review(bool[] selectedRows, string selectedTab)
        {
            Section = selectedTab;

            if(selectedRows.Where(c => !c).Count() == selectedRows.Length)
            {
                throw new ArgumentException();
            }


            switch(selectedTab)
            {
                case "Hiragana":
                    for (int i = 0; i < selectedRows.Length; i++)
                    {
                        if (selectedRows[i] == true)
                        {
                            StudiedKana.Add(Kana.Hiragana[i].ToList());
                        }
                    }
                    break;

                case "Katakana":
                    for (int i = 0; i < selectedRows.Length; i++)
                    {
                        if (selectedRows[i] == true)
                        {
                            StudiedKana.Add(Kana.Katakana[i].ToList());
                        }
                    }
                    break;
            }
        }
        #endregion



        #region Variables
        public string wrongSound = Directory.GetCurrentDirectory() + "Assets/Sounds/wrong.mp3 ";
        public List<List<Kana>> StudiedKana = new List<List<Kana>>();
        public List<Kana> kanaList = new List<Kana>();
        public int MaxKanaMastery = 5;
        public int GameProgress = 0;
        public string Section;
        #endregion



        #region Methods
        public int ChooseLevel()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t          Choose a Kana System \n");
            Console.WriteLine(" \t\t\t   1) Hiragana \t\t 2) Katakana ");
            switch (Console.ReadLine())
            {
                case "1":
                    Section = "Hiragana";
                    foreach (Kana[] list in Kana.Hiragana)
                    {
                        StudiedKana.Add(list.ToList());
                    }
                    return 1;

                case "2":
                    Section = "Katakana";
                    foreach (Kana[] list in Kana.Katakana)
                    {
                        StudiedKana.Add(list.ToList());
                    }
                    return 2;
            }
            return ChooseLevel();
        }


        public List<Kana> GetSection()
        {
            for(int i = 0; i < StudiedKana.Count(); i++)
            {
                if (kanaList.Contains(StudiedKana[i].First()))
                {
                    if (kanaList.All(i => i.KanaMastery == MaxKanaMastery))
                    {
                        continue;
                    }
                    break;
                }

                kanaList.AddRange(StudiedKana[i]);
                break;
            }
            return kanaList;
        }


        public Kana GetKana(List<Kana> section)
        {
            Kana kana;
            Random rnd = new Random();
            int rndDouble = rnd.Next(1, section.Count); 
            double index = Math.Floor((0 + (section.Count + 1 - 0) * (Math.Pow(rndDouble, 2))));

            if (section.Any(i=>i.KanaMastery == 0))
            {
                return kana = section.OrderBy(i=>i.KanaMastery).First();
            }
            if (section.Any(i=>i.KanaMastery < MaxKanaMastery))
            {
                var select = section.OrderBy(i => i.KanaMastery).ToArray();
                return kana = select[rndDouble];
            }
            return kana = section[rnd.Next(section.Count)];
        }
        

        public int CheckUserResponse(Kana kana, string response, int wrongCounter)
        {
            if(response.ToUpper() == kana.Sound)
            {
                Console.WriteLine("\t\t\t\t\tCorrect!");
                //Play kana audio
                if (kana.KanaMastery == MaxKanaMastery)
                {
                    return 4;
                }


                kana.KanaMastery++;
                if (kana.KanaMastery == MaxKanaMastery)
                {
                    GameProgress++;
                }
                return 4;
            }


            //Play wrong audio
            wrongCounter++;
            if (kana.KanaMastery > 0)
            {
                kana.KanaMastery--;
                if(kana.KanaMastery == 9 && GameProgress > 0)
                {
                    GameProgress--;
                }
            }

            
            if(wrongCounter == 3)
            {
                Console.WriteLine("\t\t\t\tCorrect Awnser : " + kana.Sound);
                return 4;
            }
            return wrongCounter;
        }



        public void StartReview()
        {

            while(GameProgress <= 46)
            {
                int wrongCounter = 0;
                Kana currentKana = GetKana(GetSection());


                Console.Clear();
                Console.WriteLine($"\t\t\t\t Mastery : {currentKana.KanaMastery}");
                Console.WriteLine($"\t\t\t\t\t {currentKana.Symbol}");
                Console.WriteLine("\t\t\t\t Enter the Kana Sound");

                ConsoleUtility.WriteProgressBar(GameProgress);

     
                while (wrongCounter < 3)
                {
                    string userResponse = Console.ReadLine();
                    wrongCounter = CheckUserResponse(currentKana, userResponse, wrongCounter);
                    
                }
                
                
            }

            Console.WriteLine("REVIEW COMPLETE !");
            


        }

        #endregion
    }
}


