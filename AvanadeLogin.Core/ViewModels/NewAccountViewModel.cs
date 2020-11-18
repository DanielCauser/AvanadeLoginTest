    using System;
using System.ComponentModel;
using System.Windows.Input;
using AvanadeLogin.Core.Models;
using AvanadeLogin.Core.Services;
using MvvmCross.ViewModels;
using ReactiveUI;

namespace AvanadeLogin.Core.ViewModels
{
    public class NewAccountViewModel : MvxViewModel, INotifyPropertyChanged
    {
        private readonly IUserAccountService _userAccountService;

        public NewAccountViewModel(IUserAccountService userAccountService)
        {
            _userAccountService = userAccountService;
            Model = new UserAccountModel();

            this.CreateAccountCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                Console.WriteLine("Account Created!");
                Model.Validade();
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
