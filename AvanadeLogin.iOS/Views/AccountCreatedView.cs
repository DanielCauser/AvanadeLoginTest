using System;
using AvanadeLogin.Core.ViewModels;
using MvvmCross.Platforms.Ios.Views;
using UIKit;

namespace AvanadeLogin.iOS.Views
{
    public partial class AccountCreatedView : MvxViewController<AccountCreatedViewModel>
    {
        public AccountCreatedView() : base("AccountCreatedView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var set = this.CreateBindingSet();
            set.Bind(BackToLogInButton).To(vm => vm.BackToLogInCommand);
            set.Apply();
        }
    }
}

