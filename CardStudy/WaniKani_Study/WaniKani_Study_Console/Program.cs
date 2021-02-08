using System;
using WaniKani_Study;
using WaniKani_Study.Review_Classes;

namespace WaniKani_Study_Console
{
    class Program
    {



        static void Main(string[] args)
        {
            IReview review = Review.ChooseSection();
            review.ChooseLevel();
            review.StartReview();
        }



        




    }



}
