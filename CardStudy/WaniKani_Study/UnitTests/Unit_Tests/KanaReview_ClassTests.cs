using System;
using NUnit.Framework;
using NUnit.Compatibility;
using WaniKani_Study.Review_Classes;



namespace WaniKani_Study_Tests.Unit_Tests
{


    [TestFixture()]
    public class KanaReviewClassTests
    {


        [Test]
        [TestCase("Hiragana", 1)]
        [TestCase("Katakana", 2)]
        public void ChooseLeve(string expSection, int expSectionNum)
        {
            string actualSection;
            int actualSectionNum;
            Kana_Review review = new Kana_Review();

            actualSectionNum = review.ChooseLevel();
            actualSection = review.Section;

            Assert.AreEqual(expSection, actualSection);
            Assert.AreEqual(expSectionNum, actualSectionNum);
        }


        [Test]
        public void GetSection()
        {
            throw new NotImplementedException();
        }


        [Test]
        public void GetKana()
        {
            throw new NotImplementedException();
        }


        [Test]
        public void CheckUserResponse()
        {
            throw new NotImplementedException();
        }


    }
}
