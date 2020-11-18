using System;
using System.Windows.Input;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using ReactiveUI;

namespace AvanadeLogin.Core.ViewModels
{
    public class AccountCreatedViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public AccountCreatedViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;

            BackToLogInCommand = ReactiveCommand.CreateFromTask(() => _navigationService.Close(this));

        }

        public ICommand BackToLogInCommand { get; }
    }
}
