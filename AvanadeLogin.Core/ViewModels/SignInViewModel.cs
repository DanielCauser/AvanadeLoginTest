using System;
using MvvmCross.Commands;
using MvvmCross.ViewModels;

namespace AvanadeLogin.Core.ViewModels
{
    public class SignInViewModel : MvxViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public IMvxCommand SignInCommand => new MvxCommand(() =>
        {
            Console.WriteLine("Signed In");
        });
        public IMvxCommand CreateAccountCommand => new MvxCommand(() =>
        {
            Console.WriteLine("Account Create");
        });
        //public string Password { get; set; }
    }
}
