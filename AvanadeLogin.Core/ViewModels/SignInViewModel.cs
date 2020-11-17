using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using PropertyChanged;
using ReactiveUI;

namespace AvanadeLogin.Core.ViewModels
{
    public class SignInViewModel : MvxViewModel, INotifyPropertyChanged
    {
        public SignInViewModel()
        {
            this.SignInCommand = ReactiveCommand.Create(() =>
            {
                Console.WriteLine("Signed In");

            }, this.WhenAnyValue(
                x => x.UserName, x => x.Password,
                (userName, password) =>
                    !string.IsNullOrEmpty(userName) &&
                    !string.IsNullOrEmpty(password)));
        }

        public string UserName { get; set; }
        public string Password { get; set; }

        //Reactive?
        public ICommand SignInCommand { get; }

        public IMvxCommand CreateAccountCommand => new MvxCommand(() =>
        {
            Console.WriteLine("Account Create");
        });
    }
}
