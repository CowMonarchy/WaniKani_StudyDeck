// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace WaniKani_Study
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSButton H_Row_Btn { get; set; }

		[Outlet]
		AppKit.NSBox Hiragana_Chart_View { get; set; }

		[Outlet]
		AppKit.NSButton Hiragana_Tab { get; set; }

		[Outlet]
		AppKit.NSButton K_Row_Btn { get; set; }

		[Outlet]
		AppKit.NSTextField KanaGame_KanaDisplay { get; set; }

		[Outlet]
		AppKit.NSView Katakana_Chart_View { get; set; }

		[Outlet]
		AppKit.NSButtonCell Katakana_Tab { get; set; }

		[Outlet]
		AppKit.NSButton M_Row_Btn { get; set; }

		[Outlet]
		AppKit.NSButton N_Row_Btn { get; set; }

		[Outlet]
		AppKit.NSButton R_Row_Btn { get; set; }

		[Outlet]
		AppKit.NSButton S_Row_Btn { get; set; }

		[Outlet]
		AppKit.NSButton T_Row_Btn { get; set; }

		[Outlet]
		AppKit.NSButton V_Row_Btn { get; set; }

		[Outlet]
		AppKit.NSButton W_Row_Btn { get; set; }

		[Outlet]
		AppKit.NSButton Y_Row_Btn { get; set; }

		[Action ("ChangeA:")]
		partial void ChangeA (Foundation.NSObject sender);

		[Action ("changeKanaSymbol:")]
		partial void changeKanaSymbol (Foundation.NSObject sender);

		[Action ("ChangeKanaSymbol:")]
		partial void ChangeKanaSymbol (Foundation.NSObject sender);

		[Action ("Hiragana_Tab_OnClick:")]
		partial void Hiragana_Tab_OnClick (Foundation.NSObject sender);

		[Action ("Katakana_Tab_OnClick:")]
		partial void Katakana_Tab_OnClick (Foundation.NSObject sender);

		[Action ("StartKanaReview:")]
		partial void StartKanaReview (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (H_Row_Btn != null) {
				H_Row_Btn.Dispose ();
				H_Row_Btn = null;
			}

			if (Hiragana_Chart_View != null) {
				Hiragana_Chart_View.Dispose ();
				Hiragana_Chart_View = null;
			}

			if (Hiragana_Tab != null) {
				Hiragana_Tab.Dispose ();
				Hiragana_Tab = null;
			}

			if (K_Row_Btn != null) {
				K_Row_Btn.Dispose ();
				K_Row_Btn = null;
			}

			if (KanaGame_KanaDisplay != null) {
				KanaGame_KanaDisplay.Dispose ();
				KanaGame_KanaDisplay = null;
			}

			if (Katakana_Chart_View != null) {
				Katakana_Chart_View.Dispose ();
				Katakana_Chart_View = null;
			}

			if (Katakana_Tab != null) {
				Katakana_Tab.Dispose ();
				Katakana_Tab = null;
			}

			if (M_Row_Btn != null) {
				M_Row_Btn.Dispose ();
				M_Row_Btn = null;
			}

			if (N_Row_Btn != null) {
				N_Row_Btn.Dispose ();
				N_Row_Btn = null;
			}

			if (R_Row_Btn != null) {
				R_Row_Btn.Dispose ();
				R_Row_Btn = null;
			}

			if (S_Row_Btn != null) {
				S_Row_Btn.Dispose ();
				S_Row_Btn = null;
			}

			if (T_Row_Btn != null) {
				T_Row_Btn.Dispose ();
				T_Row_Btn = null;
			}

			if (V_Row_Btn != null) {
				V_Row_Btn.Dispose ();
				V_Row_Btn = null;
			}

			if (W_Row_Btn != null) {
				W_Row_Btn.Dispose ();
				W_Row_Btn = null;
			}

			if (Y_Row_Btn != null) {
				Y_Row_Btn.Dispose ();
				Y_Row_Btn = null;
			}
		}
	}
}
