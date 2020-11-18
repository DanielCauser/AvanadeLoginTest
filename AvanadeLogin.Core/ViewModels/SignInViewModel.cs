using System;
using System.ComponentModel;
using System.Windows.Input;
using AvanadeLogin.Core.InfrastructureServices;
using AvanadeLogin.Core.Services;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using PropertyChanged;
using ReactiveUI;

namespace AvanadeLogin.Core.ViewModels
{
    public class SignInViewModel : MvxViewModel, INotifyPropertyChanged
    {
        private readonly IMvxNavigationService _navigationService;
        private readonly IUserAccountService _userAccountService;
        private readonly IDialogueService _dialogueService;

        public SignInViewModel(IMvxNavigationService navigationService,
            IUserAccountService userAccountService,
            IDialogueService dialogueService)
        {
            _navigationService = navigationService;
            _userAccountService = userAccountService;
            _dialogueService = dialogueService;

            this.SignInCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                var result = await _userAccountService.AuthenticateUser(UserName, Password);

                if (result)
                    _dialogueService.ShowInformation("Great Success!!");
            },
                this.WhenAnyValue(
                x => x.UserName, x => x.Password,
                (userName, password) =>
                    !string.IsNullOrEmpty(userName) &&
                    !string.IsNullOrEmpty(password)));

            this.CreateAccountCommand = ReactiveCommand.CreateFromTask(() =>
            {
                return _navigationService.Navigate<NewAccountViewModel>();
            });
        }

        public string UserName { get; set; }
        public string Password { get; set; }


        public ICommand SignInCommand { get; }
        public ICommand CreateAccountCommand { get; }
    }
}
