using AppKit; 
using System;
using System.IO;
using System.Collections.Generic;

namespace WaniKani_Study
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



        public string Symbol { get; }
        public string Sound { get; }
        public string Audio { get; }
        public int KanaMastery { get; set; }
        private static string SoundPath = Directory.GetCurrentDirectory() + "/Assets.xcassets/Sections/Kana_Section/Kana_Audio/Basic_Sounds/";
        


        public static Kana[][] Hiragana = new Kana[][]
        {
            new Kana[]{
            new Kana("あ", "A", $"{SoundPath}"  + "a.mp3"),
            new Kana("い", "I", $"{SoundPath}" + "i.mp3"),
            new Kana("う", "U", $"{SoundPath}" +  "u.mp3"),
            new Kana("え", "E", $"{SoundPath}"  + "e.mp3"),
            new Kana("お", "O", $"{SoundPath}"  + "o.mp3")},

            new Kana[]{
            new Kana("か", "KA", $"{SoundPath}"  + "ka.mp3"),
            new Kana("き", "KI", $"{SoundPath}"  + "ki.mp3"),
            new Kana("く", "KU", $"{SoundPath}"  + "ku.mp3"),
            new Kana("け", "KE", $"{SoundPath}"  + "ke.mp3"),
            new Kana("こ", "KO", $"{SoundPath}"  + "ko.mp3") },

            new Kana[]{
            new Kana("さ", "SA", $"{SoundPath}"  + "sa.mp3"),
            new Kana("し", "SHI", $"{SoundPath}"  + "shi.mp3"),
            new Kana("す", "SU", $"{SoundPath}"  + "su.mp3"),
            new Kana("せ", "SE", $"{SoundPath}"  + "se.mp3"),
            new Kana("そ", "SO", $"{SoundPath}"  + "so.mp3") },

            new Kana[]{
            new Kana("た", "TA", $"{SoundPath}"  + "ta.mp3"),
            new Kana("ち", "CHI", $"{SoundPath}"  + "chi.mp3"),
            new Kana("つ", "TSU", $"{SoundPath}"  + "tsu.mp3"),
            new Kana("て", "TE", $"{SoundPath}"  + "te.mp3"),
            new Kana("と", "TO", $"{SoundPath}"  + "to.mp3") },

            new Kana[]{
            new Kana("な", "NA", $"{SoundPath}"  + "na.mp3"),
            new Kana("に", "NI", $"{SoundPath}"  + "ni.mp3"),
            new Kana("ぬ", "NU", $"{SoundPath}"  + "nu.mp3"),
            new Kana("ね", "NE", $"{SoundPath}"  + "ne.mp3"),
            new Kana("の", "NO", $"{SoundPath}"  + "no.mp3") },

            new Kana[]{
            new Kana("は", "HA", $"{SoundPath}"  + "ha.mp3"),
            new Kana("ひ", "HI", $"{SoundPath}"  + "hi.mp3"),
            new Kana("ふ", "FU", $"{SoundPath}"  + "fu.mp3"),
            new Kana("へ", "HE", $"{SoundPath}"  + "he.mp3"),
            new Kana("ほ", "HO", $"{SoundPath}"  + "ho.mp3") },

            new Kana[]{
            new Kana("ま", "MA", $"{SoundPath}"  + "ma.mp3"),
            new Kana("み", "MI", $"{SoundPath}"  + "mi.mp3"),
            new Kana("む", "MU", $"{SoundPath}"  + "mu.mp3"),
            new Kana("め", "ME", $"{SoundPath}"  + "me.mp3"),
            new Kana("も", "MO", $"{SoundPath}"  + "mo.mp3") },

            new Kana[]{
            new Kana("や", "YA", $"{SoundPath}"  + "ya.mp3"),
            new Kana("ゆ", "YU", $"{SoundPath}"  + "yu.mp3"),
            new Kana("よ", "YO", $"{SoundPath}"  + "yo.mp3") },

            new Kana[]{
            new Kana("ら", "RA", $"{SoundPath}"  + "ra.mp3"),
            new Kana("り", "RI", $"{SoundPath}"  + "ri.mp3"),
            new Kana("る", "RU", $"{SoundPath}"  + "ru.mp3"),
            new Kana("れ", "RE", $"{SoundPath}"  + "re.mp3"),
            new Kana("ろ", "RO", $"{SoundPath}"  + "ro.mp3") },

            new Kana[]{
            new Kana("わ", "WA", $"{SoundPath}"  + "wa.mp3"),
            new Kana("を", "WO", $"{SoundPath}"  + "wo.mp3"),
            new Kana("ん", "N", $"{SoundPath}"  + "n.mp3") }
        };



        public static Kana[][] Katakana = new Kana[][]
        {
            new Kana[]{
            new Kana("ア", "A", $"{SoundPath}"  + "a.mp3"),
            new Kana("イ", "I", $"{SoundPath}"  + "i.mp3"),
            new Kana("ウ", "U", $"{SoundPath}"  + "u.mp3"),
            new Kana("エ", "E", $"{SoundPath}"  + "e.mp3"),
            new Kana("オ", "O", $"{SoundPath}"  + "o.mp3") },

            new Kana[]{
            new Kana("カ", "KA", $"{SoundPath}"  + "ka.mp3"),
            new Kana("キ", "KI", $"{SoundPath}"  + "ki.mp3"),
            new Kana("ク", "KU", $"{SoundPath}"  + "ku.mp3"),
            new Kana("ケ", "KE", $"{SoundPath}"  + "ke.mp3"),
            new Kana("コ", "KO", $"{SoundPath}"  + "ko.mp3") },

            new Kana[]{
            new Kana("サ", "SA", $"{SoundPath}"  + "sa.mp3"),
            new Kana("シ", "SHI", $"{SoundPath}"  + "shi.mp3"),
            new Kana("ス", "SU", $"{SoundPath}"  + "su.mp3"),
            new Kana("セ", "SE", $"{SoundPath}"  + "se.mp3"),
            new Kana("ソ", "SO", $"{SoundPath}"  + "so.mp3") },

            new Kana[]{
            new Kana("タ", "TA", $"{SoundPath}"  + "ta.mp3"),
            new Kana("チ", "CHI", $"{SoundPath}"  + "chi.mp3"),
            new Kana("ツ", "TSU", $"{SoundPath}"  + "tsu.mp3"),
            new Kana("テ", "TE", $"{SoundPath}"  + "te.mp3"),
            new Kana("ト", "TO", $"{SoundPath}"  + "to.mp3") },

            new Kana[]{
            new Kana("ナ", "NA", $"{SoundPath}"  + "na.mp3"),
            new Kana("ニ", "NI", $"{SoundPath}"  + "ni.mp3"),
            new Kana("ヌ", "NU", $"{SoundPath}"  + "nu.mp3"),
            new Kana("ネ", "NE", $"{SoundPath}"  + "ne.mp3"),
            new Kana("ノ", "NO", $"{SoundPath}"  + "no.mp3") },

            new Kana[]{
            new Kana("ハ", "HA", $"{SoundPath}"  + "ha.mp3"),
            new Kana("ヒ", "HI", $"{SoundPath}"  + "hi.mp3"),
            new Kana("フ", "FU", $"{SoundPath}"  + "fu.mp3"),
            new Kana("ヘ", "HE", $"{SoundPath}"  + "he.mp3"),
            new Kana("ホ", "HO", $"{SoundPath}"  + "ho.mp3") },

            new Kana[]{
            new Kana("マ", "MA", $"{SoundPath}"  + "ma.mp3"),
            new Kana("ミ", "MI", $"{SoundPath}"  + "mi.mp3"),
            new Kana("ム", "MU", $"{SoundPath}"  + "mu.mp3"),
            new Kana("メ", "ME", $"{SoundPath}"  + "me.mp3"),
            new Kana("モ", "MO", $"{SoundPath}"  + "mo.mp3") },

            new Kana[]{
            new Kana("ヤ", "YA", $"{SoundPath}"  + "ya.mp3"),
            new Kana("ユ", "YU", $"{SoundPath}"  + "yu.mp3"),
            new Kana("ヨ", "YO", $"{SoundPath}"  + "yo.mp3") },

            new Kana[]{
            new Kana("ラ", "RA", $"{SoundPath}"  + "ra.mp3"),
            new Kana("リ", "RI", $"{SoundPath}"  + "ri.mp3"),
            new Kana("ル", "RU", $"{SoundPath}"  + "ru.mp3"),
            new Kana("レ", "RE", $"{SoundPath}"  + "re.mp3"),
            new Kana("ロ", "RO", $"{SoundPath}"  + "ro.mp3") },

            new Kana[]{
            new Kana("ワ", "WA", $"{SoundPath}"  + "wa.mp3"),
            new Kana("ヲ", "WO", $"{SoundPath}"  + "wo.mp3"),
            new Kana("ン", "N", $"{SoundPath}"  + "n.mp3") }

        };





    }











    
}
