    using System;
using System.ComponentModel;
using System.Windows.Input;
using AvanadeLogin.Core.Models;
using AvanadeLogin.Core.Services;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using ReactiveUI;

namespace AvanadeLogin.Core.ViewModels
{
    public class NewAccountViewModel : MvxViewModel, INotifyPropertyChanged
    {
        private readonly IUserAccountService _userAccountService;
        private readonly IMvxNavigationService _mvxNavigationService;

        public NewAccountViewModel(IUserAccountService userAccountService, IMvxNavigationService mvxNavigationService)
        {
            _userAccountService = userAccountService;
            _mvxNavigationService = mvxNavigationService;
            Model = new UserAccountModel();

            this.CreateAccountCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                Model.Validade();
                await _userAccountService.CreateUserAccount(Model);
                await _mvxNavigationService.Navigate<AccountCreatedViewModel>();
                await _mvxNavigationService.Close(this); 
            },
                this.WhenAnyValue(
                x => x.Model.FirstName,
                x => x.Model.LastName,
                x => x.Model.Username,
                x => x.Model.Password,
                x => x.Model.PhoneNumber,
                (firstName, lastName, username, password, phoneNumber) =>
                    !string.IsNullOrEmpty(Model.FirstName) &&
                    !string.IsNullOrEmpty(Model.LastName) &&
                    !string.IsNullOrEmpty(Model.Username) &&
                    !string.IsNullOrEmpty(Model.Password) &&
                    !string.IsNullOrEmpty(Model.PhoneNumber)));
        }

        public UserAccountModel Model {get; set;}

        public ICommand CreateAccountCommand { get; }
    }
}
