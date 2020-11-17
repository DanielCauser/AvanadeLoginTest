using System;
using AvanadeLogin.Core.ViewModels;
using MvvmCross.Platforms.Ios.Views;
using UIKit;

namespace AvanadeLogin.iOS.Views
{
    public partial class NewAccountView : MvxViewController<NewAccountViewModel>
    {
        public NewAccountView() : base(nameof(NewAccountView), null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var set = this.CreateBindingSet();
            set.Bind(FirstNameTextField).To(vm => vm.Model.FirstName);
            set.Bind(LastNameTextField).To(vm => vm.Model.LastName);
            set.Bind(UsernameTextField).To(vm => vm.Model.Username);
            set.Bind(PasswordTextField).To(vm => vm.Model.Password);
            set.Bind(PhoneNumberTextField).To(vm => vm.Model.PhoneNumber);
            set.Bind(ServiceStartDateTextField).To(vm => vm.Model.ServiceStartDate);
            set.Bind(CreateAccountButton).To(vm => vm.CreateAccountCommand);
            set.Apply();
        }
    }
}

