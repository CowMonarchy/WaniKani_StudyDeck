using System;
using System.IO;
using Humanizer;

namespace WaniKani_Study.Object_Classes
{
    public class Kana
    {



        public Kana(string symbol, string sound, string audio)
        {
            Symbol = symbol;
            Sound = sound;
            Audio = audio;
            KanaMastery = 0;

        }


  
        private static string SoundPath = Directory.GetCurrentDirectory() + "Assets/Sounds/Kana_Sounds/";
        public int KanaMastery { get; set; }
        public string Symbol { get; }
        public string Sound { get; }
        public string Audio { get; }
       
        

        public static Kana[][] Hiragana = new Kana[][]
        {
            new Kana[]{
            new Kana("あ".Humanize(), "A", $"{SoundPath}"  + "a.mp3"),
            new Kana("い".Humanize(), "I", $"{SoundPath}" + "i.mp3"),
            new Kana("う".Humanize(), "U", $"{SoundPath}" +  "u.mp3"),
            new Kana("え".Humanize(), "E", $"{SoundPath}"  + "e.mp3"),
            new Kana("お".Humanize(), "O", $"{SoundPath}"  + "o.mp3")},

            new Kana[]{
            new Kana("か".Humanize(), "KA", $"{SoundPath}"  + "ka.mp3"),
            new Kana("き".Humanize(), "KI", $"{SoundPath}"  + "ki.mp3"),
            new Kana("く".Humanize(), "KU", $"{SoundPath}"  + "ku.mp3"),
            new Kana("け".Humanize(), "KE", $"{SoundPath}"  + "ke.mp3"),
            new Kana("こ".Humanize(), "KO", $"{SoundPath}"  + "ko.mp3") },

            new Kana[]{
            new Kana("さ".Humanize(), "SA", $"{SoundPath}"  + "sa.mp3"),
            new Kana("し".Humanize(), "SHI", $"{SoundPath}"  + "shi.mp3"),
            new Kana("す".Humanize(), "SU", $"{SoundPath}"  + "su.mp3"),
            new Kana("せ".Humanize(), "SE", $"{SoundPath}"  + "se.mp3"),
            new Kana("そ".Humanize(), "SO", $"{SoundPath}"  + "so.mp3") },

            new Kana[]{
            new Kana("た".Humanize(), "TA", $"{SoundPath}"  + "ta.mp3"),
            new Kana("ち".Humanize(), "CHI", $"{SoundPath}"  + "chi.mp3"),
            new Kana("つ".Humanize(), "TSU", $"{SoundPath}"  + "tsu.mp3"),
            new Kana("て".Humanize(), "TE", $"{SoundPath}"  + "te.mp3"),
            new Kana("と".Humanize(), "TO", $"{SoundPath}"  + "to.mp3") },

            new Kana[]{
            new Kana("な".Humanize(), "NA", $"{SoundPath}"  + "na.mp3"),
            new Kana("に".Humanize(), "NI", $"{SoundPath}"  + "ni.mp3"),
            new Kana("ぬ".Humanize(), "NU", $"{SoundPath}"  + "nu.mp3"),
            new Kana("ね".Humanize(), "NE", $"{SoundPath}"  + "ne.mp3"),
            new Kana("の".Humanize(), "NO", $"{SoundPath}"  + "no.mp3") },

            new Kana[]{
            new Kana("は".Humanize(), "HA", $"{SoundPath}"  + "ha.mp3"),
            new Kana("ひ".Humanize(), "HI", $"{SoundPath}"  + "hi.mp3"),
            new Kana("ふ".Humanize(), "FU", $"{SoundPath}"  + "fu.mp3"),
            new Kana("へ".Humanize(), "HE", $"{SoundPath}"  + "he.mp3"),
            new Kana("ほ".Humanize(), "HO", $"{SoundPath}"  + "ho.mp3") },

            new Kana[]{
            new Kana("ま".Humanize(), "MA", $"{SoundPath}"  + "ma.mp3"),
            new Kana("み".Humanize(), "MI", $"{SoundPath}"  + "mi.mp3"),
            new Kana("む".Humanize(), "MU", $"{SoundPath}"  + "mu.mp3"),
            new Kana("め".Humanize(), "ME", $"{SoundPath}"  + "me.mp3"),
            new Kana("も".Humanize(), "MO", $"{SoundPath}"  + "mo.mp3") },

            new Kana[]{
            new Kana("や".Humanize(), "YA", $"{SoundPath}"  + "ya.mp3"),
            new Kana("ゆ".Humanize(), "YU", $"{SoundPath}"  + "yu.mp3"),
            new Kana("よ".Humanize(), "YO", $"{SoundPath}"  + "yo.mp3") },

            new Kana[]{
            new Kana("ら".Humanize(), "RA", $"{SoundPath}"  + "ra.mp3"),
            new Kana("り".Humanize(), "RI", $"{SoundPath}"  + "ri.mp3"),
            new Kana("る".Humanize(), "RU", $"{SoundPath}"  + "ru.mp3"),
            new Kana("れ".Humanize(), "RE", $"{SoundPath}"  + "re.mp3"),
            new Kana("ろ".Humanize(), "RO", $"{SoundPath}"  + "ro.mp3") },

            new Kana[]{
            new Kana("わ".Humanize(), "WA", $"{SoundPath}"  + "wa.mp3"),
            new Kana("を".Humanize(), "WO", $"{SoundPath}"  + "wo.mp3"),
            new Kana("ん".Humanize(), "N", $"{SoundPath}"  + "n.mp3") }
        };



        public static Kana[][] Katakana = new Kana[][]
        {
            new Kana[]{
            new Kana("ア".Humanize(), "A", $"{SoundPath}"  + "a.mp3"),
            new Kana("イ".Humanize(), "I", $"{SoundPath}"  + "i.mp3"),
            new Kana("ウ".Humanize(), "U", $"{SoundPath}"  + "u.mp3"),
            new Kana("エ".Humanize(), "E", $"{SoundPath}"  + "e.mp3"),
            new Kana("オ".Humanize(), "O", $"{SoundPath}"  + "o.mp3") },

            new Kana[]{
            new Kana("カ".Humanize(), "KA", $"{SoundPath}"  + "ka.mp3"),
            new Kana("キ".Humanize(), "KI", $"{SoundPath}"  + "ki.mp3"),
            new Kana("ク".Humanize(), "KU", $"{SoundPath}"  + "ku.mp3"),
            new Kana("ケ".Humanize(), "KE", $"{SoundPath}"  + "ke.mp3"),
            new Kana("コ".Humanize(), "KO", $"{SoundPath}"  + "ko.mp3") },

            new Kana[]{
            new Kana("サ".Humanize(), "SA", $"{SoundPath}"  + "sa.mp3"),
            new Kana("シ".Humanize(), "SHI", $"{SoundPath}"  + "shi.mp3"),
            new Kana("ス".Humanize(), "SU", $"{SoundPath}"  + "su.mp3"),
            new Kana("セ".Humanize(), "SE", $"{SoundPath}"  + "se.mp3"),
            new Kana("ソ".Humanize(), "SO", $"{SoundPath}"  + "so.mp3") },

            new Kana[]{
            new Kana("タ".Humanize(), "TA", $"{SoundPath}"  + "ta.mp3"),
            new Kana("チ".Humanize(), "CHI", $"{SoundPath}"  + "chi.mp3"),
            new Kana("ツ".Humanize(), "TSU", $"{SoundPath}"  + "tsu.mp3"),
            new Kana("テ".Humanize(), "TE", $"{SoundPath}"  + "te.mp3"),
            new Kana("ト".Humanize(), "TO", $"{SoundPath}"  + "to.mp3") },

            new Kana[]{
            new Kana("ナ".Humanize(), "NA", $"{SoundPath}"  + "na.mp3"),
            new Kana("ニ".Humanize(), "NI", $"{SoundPath}"  + "ni.mp3"),
            new Kana("ヌ".Humanize(), "NU", $"{SoundPath}"  + "nu.mp3"),
            new Kana("ネ".Humanize(), "NE", $"{SoundPath}"  + "ne.mp3"),
            new Kana("ノ".Humanize(), "NO", $"{SoundPath}"  + "no.mp3") },

            new Kana[]{
            new Kana("ハ".Humanize(), "HA", $"{SoundPath}"  + "ha.mp3"),
            new Kana("ヒ".Humanize(), "HI", $"{SoundPath}"  + "hi.mp3"),
            new Kana("フ".Humanize(), "FU", $"{SoundPath}"  + "fu.mp3"),
            new Kana("ヘ".Humanize(), "HE", $"{SoundPath}"  + "he.mp3"),
            new Kana("ホ".Humanize(), "HO", $"{SoundPath}"  + "ho.mp3") },

            new Kana[]{
            new Kana("マ".Humanize(), "MA", $"{SoundPath}"  + "ma.mp3"),
            new Kana("ミ".Humanize(), "MI", $"{SoundPath}"  + "mi.mp3"),
            new Kana("ム".Humanize(), "MU", $"{SoundPath}"  + "mu.mp3"),
            new Kana("メ".Humanize(), "ME", $"{SoundPath}"  + "me.mp3"),
            new Kana("モ".Humanize(), "MO", $"{SoundPath}"  + "mo.mp3") },

            new Kana[]{
            new Kana("ヤ".Humanize(), "YA", $"{SoundPath}"  + "ya.mp3"),
            new Kana("ユ".Humanize(), "YU", $"{SoundPath}"  + "yu.mp3"),
            new Kana("ヨ".Humanize(), "YO", $"{SoundPath}"  + "yo.mp3") },

            new Kana[]{
            new Kana("ラ".Humanize(), "RA", $"{SoundPath}"  + "ra.mp3"),
            new Kana("リ".Humanize(), "RI", $"{SoundPath}"  + "ri.mp3"),
            new Kana("ル".Humanize(), "RU", $"{SoundPath}"  + "ru.mp3"),
            new Kana("レ".Humanize(), "RE", $"{SoundPath}"  + "re.mp3"),
            new Kana("ロ".Humanize(), "RO", $"{SoundPath}"  + "ro.mp3") },

            new Kana[]{
            new Kana("ワ".Humanize(), "WA", $"{SoundPath}"  + "wa.mp3"),
            new Kana("ヲ".Humanize(), "WO", $"{SoundPath}"  + "wo.mp3"),
            new Kana("ン".Humanize(), "N", $"{SoundPath}"  + "n.mp3") }

        };




    }



}
