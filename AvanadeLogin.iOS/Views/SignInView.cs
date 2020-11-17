using System;
using AvanadeLogin.Core.ViewModels;
using MvvmCross.Platforms.Ios.Views;
using UIKit;

namespace AvanadeLogin.iOS.Views
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
            var set = CreateBindingSet();
            set.Bind(UsernameTextField).For(x => x.Text).To(vm => vm);
            set.Bind(UserPasswordTextField).For(x => x.Text).To(vm => vm.Password);
            set.Bind(SignInButton).To(vm => vm.SignInCommand);
            set.Bind(CreateAccountButton).To(vm => vm.CreateAccountCommand);
            set.Apply();


            View.AddGestureRecognizer(new UITapGestureRecognizer(() =>
            {
                this.UsernameTextField.ResignFirstResponder();
                this.UserPasswordTextField.ResignFirstResponder();
            }));
        }
    }
}

