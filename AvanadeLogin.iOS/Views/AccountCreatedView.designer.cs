// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace AvanadeLogin.iOS.Views
{
    [Register ("AccountCreatedView")]
    partial class AccountCreatedView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton BackToLogInButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (BackToLogInButton != null) {
                BackToLogInButton.Dispose ();
                BackToLogInButton = null;
            }
        }
    }
}