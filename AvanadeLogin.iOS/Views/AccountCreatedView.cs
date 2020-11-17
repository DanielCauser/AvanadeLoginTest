using System;
using AvanadeLogin.Core.ViewModels;
using MvvmCross.Platforms.Ios.Views;
using UIKit;

namespace TipCalc.UI.iOS.Views
{
    public partial class AccountCreatedView : MvxViewController<AccountCreatedViewModel>
    {
        public AccountCreatedView() : base("AccountCreatedView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }
    }
}

