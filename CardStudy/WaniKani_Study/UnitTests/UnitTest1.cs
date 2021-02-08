//using System;
//using System.Collections.Generic;
//using System.Linq;
//using NUnit.Framework;
//using WaniKani_Study;



//namespace WaniKani_Study_Unit_Tests
//{



//    [TestFixture()]
//    public class KanaReview_MainPage_Unit_Tests
//    {



//        [Test]
//        [Category("Positive_Test")]
//        [TestCase(new bool[] { true, true, true, true, true, true, true, true, true, true }, "Hiragana")]
//        [TestCase(new bool[] { true, true, true, true, true, true, true, true, true, false }, "Hiragana")]
//        [TestCase(new bool[] { true, true, true, true, true, true, true, true, false, false }, "Hiragana")]
//        [TestCase(new bool[] { true, true, true, true, true, true, true, false, false, false }, "Hiragana")]
//        [TestCase(new bool[] { true, true, true, true, true, true, false, false, false, false }, "Hiragana")]
//        [TestCase(new bool[] { true, true, true, true, true, false, false, false, false, false }, "Hiragana")]
//        [TestCase(new bool[] { true, true, true, true, false, false, false, false, false, false }, "Hiragana")]
//        [TestCase(new bool[] { true, true, true, false, false, false, false, false, false, false }, "Hiragana")]
//        [TestCase(new bool[] { true, true, false, false, false, false, false, false, false, false }, "Hiragana")]
//        [TestCase(new bool[] { true, false, false, false, false, false, false, false, false, false }, "Hiragana")]
//        [TestCase(new bool[] { false, false, false, false, false, false, false, false, false, true }, "Hiragana")]
//        [TestCase(new bool[] { false, false, false, false, false, false, false, false, true, true }, "Hiragana")]
//        [TestCase(new bool[] { false, false, false, false, false, false, false, true, true, true }, "Hiragana")]
//        [TestCase(new bool[] { false, false, false, false, false, false, true, true, true, true }, "Hiragana")]
//        [TestCase(new bool[] { false, false, false, false, false, true, true, true, true, true }, "Hiragana")]
//        [TestCase(new bool[] { false, false, false, false, true, true, true, true, true, true }, "Hiragana")]
//        [TestCase(new bool[] { false, false, false, true, true, true, true, true, true, true }, "Hiragana")]
//        [TestCase(new bool[] { false, false, true, true, true, true, true, true, true, true }, "Hiragana")]
//        [TestCase(new bool[] { false, true, true, true, true, true, true, true, true, true }, "Hiragana")]
//        [TestCase(new bool[] { true, true, true, true, true, true, true, true, true, true }, "Katakana")]
//        [TestCase(new bool[] { true, true, true, true, true, true, true, true, true, false }, "Katakana")]
//        [TestCase(new bool[] { true, true, true, true, true, true, true, true, false, false }, "Katakana")]
//        [TestCase(new bool[] { true, true, true, true, true, true, true, false, false, false }, "Katakana")]
//        [TestCase(new bool[] { true, true, true, true, true, true, false, false, false, false }, "Katakana")]
//        [TestCase(new bool[] { true, true, true, true, true, false, false, false, false, false }, "Katakana")]
//        [TestCase(new bool[] { true, true, true, true, false, false, false, false, false, false }, "Katakana")]
//        [TestCase(new bool[] { true, true, true, false, false, false, false, false, false, false }, "Katakana")]
//        [TestCase(new bool[] { true, true, false, false, false, false, false, false, false, false }, "Katakana")]
//        [TestCase(new bool[] { true, false, false, false, false, false, false, false, false, false }, "Katakana")]
//        [TestCase(new bool[] { false, false, false, false, false, false, false, false, false, true }, "Katakana")]
//        [TestCase(new bool[] { false, false, false, false, false, false, false, false, true, true }, "Katakana")]
//        [TestCase(new bool[] { false, false, false, false, false, false, false, true, true, true }, "Katakana")]
//        [TestCase(new bool[] { false, false, false, false, false, false, true, true, true, true }, "Katakana")]
//        [TestCase(new bool[] { false, false, false, false, false, true, true, true, true, true }, "Katakana")]
//        [TestCase(new bool[] { false, false, false, false, true, true, true, true, true, true }, "Katakana")]
//        [TestCase(new bool[] { false, false, false, true, true, true, true, true, true, true }, "Katakana")]
//        [TestCase(new bool[] { false, false, true, true, true, true, true, true, true, true }, "Katakana")]
//        [TestCase(new bool[] { false, true, true, true, true, true, true, true, true, true }, "Katakana")]
//        public void KanaReview_MainPage_OnlySelectedRows(bool[] rowSelections, string section)
//        {


//            int kanaCount = 0;
//            int[] rowValues = new int[] { 5, 5, 5, 5, 5, 5, 5, 3, 5, 3 };

//            for (int i = 0; i < rowSelections.Length; i++)
//            {
//                if (rowSelections[i] == true)
//                {
//                    kanaCount += rowValues[i];
//                }
//            }


//            Kana_Review review = new Kana_Review(rowSelections, section);

//            IEnumerable<Kana> HiraganaKana = Kana.Hiragana.SelectMany(a => a);
//            IEnumerable<Kana> KatakanaKana = Kana.Katakana.SelectMany(a => a);
//            IEnumerable<Kana> gatheredKana = review.StudiedKana.SelectMany(a => a);


//            if (section == "Hiragana")
//            {
//                Assert.Multiple(() =>
//                {
//                    Assert.AreSame(section, review.Section);
//                    Assert.True(kanaCount == review.StudiedKana.Count());
//                    //Checks if all Kana inside of StudiedKana List are also present inside of Kana.CorrectKana[][]
//                    Assert.NotZero(review.StudiedKana[1].Where(i => Kana.Hiragana.Any(ii => ii.Contains(i))).Count());

//                    //  Assert.NotZero(review.StudiedKana.SelectMany(i => Kana.Hiragana.Any(ii => ii.ToList().Contains(i))).Count());
//                    CollectionAssert.AreEquivalent(HiraganaKana, gatheredKana);
//                });
//            }
//            else
//            {
//                Assert.Multiple(() =>
//                {
//                    Assert.AreSame(section, review.Section);
//                    Assert.True(kanaCount == review.StudiedKana.Count());
//                    //Checks if all Kana inside of StudiedKana List are also present inside of Kana.CorrectKana[][]
//                    //    Assert.NotZero(review.StudiedKana.Where(i => Kana.Katakana.Any(ii => ii.Contains(i))).Count());
//                    Assert.Contains(gatheredKana, KatakanaKana.ToList());
//                });

//            }
//        }



//        [Test]
//        [Category("Negative_Test")]
//        [TestCase(new bool[] { false, false, false, false, false, false, false, false, false, false }, "Hiragana")]
//        [TestCase(new bool[] { false, false, false, false, false, false, false, false, false, false }, "Katakana")]
//        public void KanaReview_MainPage_NoSelectedRows(bool[] rowSelections, string section)
//        {
//            Assert.Throws<System.ArgumentException>(() => new Kana_Review(rowSelections, section));

//        }



//    }



//}
