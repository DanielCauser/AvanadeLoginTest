using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Input;
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
        private readonly IAuthenticationService _authenticationService;

        public SignInViewModel(IMvxNavigationService navigationService,
            IAuthenticationService authenticationService)
        {
            _navigationService = navigationService;
            _authenticationService = authenticationService;

            this.SignInCommand = ReactiveCommand.Create(() => _authenticationService.AuthenticateUser(UserName, Password),
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
