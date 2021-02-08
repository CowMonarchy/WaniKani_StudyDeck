using System;



namespace WaniKani_Study.Review_Classes
{


    public interface IReview
    {
        public int ChooseLevel();
        public void StartReview(); 
    }



    public static class Review
    {



        public static IReview ChooseSection()
        {
                IReview review;
                Console.Clear();
                Console.WriteLine("\t\t\t\t -- Welcome to WaniKani Rapid study -- ");
                Console.WriteLine("\t\t\t\t - To Get Started, Select a Section - \n ");
                Console.WriteLine("\t\t\t\t             1) Kana \n");
                Console.WriteLine("\t\t\t\t             2) Kanji \n");
                Console.WriteLine("\t\t\t\t             3) Vocabulary \n");
                switch (Console.ReadLine())
                {
                    case "1":
                        return review = new Kana_Review(); 

                    case "2":
                        break;

                    case "3":
                        break;
                }
            return ChooseSection();
        }

        public static IReview ChooseSection(string str)
        {
            IReview review;
            Console.Clear();
            Console.WriteLine("\t\t\t\t -- Welcome to WaniKani Rapid study -- ");
            Console.WriteLine("\t\t\t\t - To Get Started, Select a Section - \n ");
            Console.WriteLine("\t\t\t\t             1) Kana \n");
            Console.WriteLine("\t\t\t\t             2) Kanji \n");
            Console.WriteLine("\t\t\t\t             3) Vocabulary \n");
            switch (str)
            {
                case "1":
                    return review = new Kana_Review();

                case "2":
                    break;

                case "3":
                    break;
            }
            return ChooseSection();
        }





    }


}
