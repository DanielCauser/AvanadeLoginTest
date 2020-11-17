using System;
using AvanadeLogin.Core.ViewModels;
using MvvmCross.Platforms.Ios.Views;
using UIKit;

namespace TipCalc.UI.iOS.Views
{
    public partial class SignInView : MvxViewController<SignInViewModel>
    {
        public SignInView() : base(nameof(SignInView), null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet();
            set.Bind(UsernameTextField).For(x => x.Text).To(vm => vm.UserName);
            set.Bind(PasswordTextField).For(x => x.Text).To(vm => vm.Password);
            set.Bind(SigninButton).To(vm => vm.SignInCommand);
            set.Bind(NewAccountButton).To(vm => vm.CreateAccountCommand);
            set.Apply();
        }
    }
}

