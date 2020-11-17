using System;
using System.Threading.Tasks;
using AvanadeLogin.Core.ViewModels;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace AvanadeLogin.Core
{
    public class AvanadeLoginAppStart : MvxAppStart
    {
        public AvanadeLoginAppStart(IMvxApplication application, IMvxNavigationService navigationService) : base(application, navigationService)
        {
        }

        protected override Task NavigateToFirstViewModel(object hint = null)
        {
            return NavigationService.Navigate<SignInViewModel>();
        }
    }
}
