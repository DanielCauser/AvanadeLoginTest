using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Input;
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

        public SignInViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;

            this.SignInCommand = ReactiveCommand.Create(() =>
            {
                Console.WriteLine("Signed In");

            }, this.WhenAnyValue(
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
