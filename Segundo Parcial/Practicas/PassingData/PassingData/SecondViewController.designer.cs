// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace PassingData
{
	[Register ("SecondViewController")]
	partial class SecondViewController
	{
		[Outlet]
		UIKit.UITextView txtSecond { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (txtSecond != null) {
				txtSecond.Dispose ();
				txtSecond = null;
			}
		}
	}
}
