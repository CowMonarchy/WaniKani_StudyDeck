using System;
using NUnit.Framework;
using NUnit.Compatibility;
using WaniKani_Study.Review_Classes;



namespace WaniKani_Study_Tests.Unit_Tests
{


    [TestFixture()]
    public class ReviewClassTests
    {
  

        [Test]
        [TestCase("1", typeof(Kana_Review))]
        public void ReviewClass_ChooseSection(string section, IReview expected)
        {
            IReview actual;
            
            actual = Review.ChooseSection(section);

            Assert.Equals(expected, actual); 

        }
    }
}
