using System;
using System.Linq; 
using System.Collections.Generic; 
using AppKit;
using Foundation;

namespace WaniKani_Study
{
    public partial class ViewController : NSViewController
    {



        Kana activeKana;




        #region ControllerInitialMethods
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
        #endregion



        #region Kana_Page
        ///--------------- Main Page --------------------------------
        partial void Hiragana_Tab_OnClick(Foundation.NSObject sender)
        {
            Hiragana_Tab.State = NSCellStateValue.On;
            Hiragana_Chart_View.Hidden = false;

            Katakana_Tab.State = NSCellStateValue.Off;
            Katakana_Chart_View.Hidden = true;
        }


        partial void Katakana_Tab_OnClick(Foundation.NSObject sender)
        {
            Katakana_Tab.State = NSCellStateValue.On;
            Katakana_Chart_View.Hidden = false;

            Hiragana_Tab.State = NSCellStateValue.Off;
            Hiragana_Chart_View.Hidden = true;

        }


        public bool[] CheckSelectedRows()
        {
            bool[] rowSelections = new bool[10];

            rowSelections[0] = V_Row_Btn.State == NSCellStateValue.On;
            rowSelections[1] = K_Row_Btn.State == NSCellStateValue.On;
            rowSelections[2] = S_Row_Btn.State == NSCellStateValue.On;
            rowSelections[3] = T_Row_Btn.State == NSCellStateValue.On;
            rowSelections[4] = N_Row_Btn.State == NSCellStateValue.On;
            rowSelections[5] = H_Row_Btn.State == NSCellStateValue.On;
            rowSelections[6] = M_Row_Btn.State == NSCellStateValue.On;
            rowSelections[7] = Y_Row_Btn.State == NSCellStateValue.On;
            rowSelections[8] = R_Row_Btn.State == NSCellStateValue.On;
            rowSelections[9] = W_Row_Btn.State == NSCellStateValue.On;

            return rowSelections; 
        }
        ///---------------------Main Page ------------------------------



        ///-------------------- Review Page ----------------------------




        partial void ChangeKanaSymbol(Foundation.NSObject sender)
        {
            KanaGame_KanaDisplay.Changed += (a, e) =>
            {
                KanaGame_KanaDisplay.StringValue = activeKana.Symbol;
            };

           // KanaGame_KanaDisplay.StringValue = activeKana.Symbol;


        }


        partial void StartKanaReview(Foundation.NSObject sender)
        {
            Kana_Review review;

            if (Hiragana_Tab.State == NSCellStateValue.On)
            {
               review = new Kana_Review(CheckSelectedRows(), "Hiragana");
            }
            else
            {
                review = new Kana_Review(CheckSelectedRows(), "Katakana");
            }


            List<Kana> sections = review.GetSection();

            activeKana = review.GetKana(sections);

            ChangeKanaSymbol(sender);

            //while (sections.All(i => i.KanaMastery < 10))
            //{
            //    activeKana = review.GetKana(sections);

            //    ChangeKanaSymbol(sender);
                

            //}
            
        }



        ///-------------------- Review Page ----------------------------
        #endregion

    }
}
