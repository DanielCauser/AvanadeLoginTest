using System;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.ViewModels;

namespace AvanadeLogin.Core.ViewModels
{
    public class SignInViewModel : MvxViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        //Reactive?
        public IMvxCommand SignInCommand => new MvxCommand(() =>
        {
            Console.WriteLine("Signed In");
        });

        //Reactive?
        public IMvxCommand CreateAccountCommand => new MvxCommand(() =>
        {
            Console.WriteLine("Account Create");
        });
    }
}
