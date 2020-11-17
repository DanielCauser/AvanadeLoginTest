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
    [Register ("SignInView")]
    partial class SignInView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CreateAccountButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton SignInButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField UsernameTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField UserPasswordTextField { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (CreateAccountButton != null) {
                CreateAccountButton.Dispose ();
                CreateAccountButton = null;
            }

            if (SignInButton != null) {
                SignInButton.Dispose ();
                SignInButton = null;
            }

            if (UsernameTextField != null) {
                UsernameTextField.Dispose ();
                UsernameTextField = null;
            }

            if (UserPasswordTextField != null) {
                UserPasswordTextField.Dispose ();
                UserPasswordTextField = null;
            }
        }
    }
}