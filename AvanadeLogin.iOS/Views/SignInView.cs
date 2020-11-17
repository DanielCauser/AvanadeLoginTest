using System;
using AvanadeLogin.Core.ViewModels;
using MvvmCross.Platforms.Ios.Views;
using UIKit;

namespace TipCalc.UI.iOS.Views
{
    public partial class SignInView : MvxViewController<SignInViewModel>
    {
        public SignInView() : base("SignInView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }
    }
}

