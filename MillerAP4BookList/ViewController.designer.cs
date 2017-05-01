// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace MillerAP4BookList
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ambtnAdd { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView amtblBooks { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField amtxtISBN { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField amtxtTitle { get; set; }

        [Action ("AmbtnAdd_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void AmbtnAdd_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (ambtnAdd != null) {
                ambtnAdd.Dispose ();
                ambtnAdd = null;
            }

            if (amtblBooks != null) {
                amtblBooks.Dispose ();
                amtblBooks = null;
            }

            if (amtxtISBN != null) {
                amtxtISBN.Dispose ();
                amtxtISBN = null;
            }

            if (amtxtTitle != null) {
                amtxtTitle.Dispose ();
                amtxtTitle = null;
            }
        }
    }
}