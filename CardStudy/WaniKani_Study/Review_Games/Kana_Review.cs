using AppKit;
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;



namespace WaniKani_Study
{



    public class Kana_Review
    {



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


        
        public string Section;
        public int GameProgress = 0;
        public List<List<Kana>> StudiedKana = new List<List<Kana>>();
        public string wrongSound = Directory.GetCurrentDirectory() + "/Assets.xcassets/Sections/Kana_Section/Kana_Audio/wrong.mp3";



        public Kana GetKana(List<Kana> section)
        {
            Kana kana; 
            Random rnd = new Random();
 
            if(section.Any(i=>i.KanaMastery < 10))
            {
                return kana = section.OrderBy(i => i.KanaMastery).First();
            }
            return kana = section[rnd.Next(section.Count)];
        }
        


        public List<Kana> GetSection()
        {
       
            foreach (List<Kana> item in StudiedKana)
            {
                if (item.All(i => i.KanaMastery == 10))
                {
                    continue;
                }
                return item;
            }

            return (List<Kana>)StudiedKana.SelectMany(i => i);
        }
    }
}


