using System;
using AvanadeLogin.Core.ViewModels;
using MvvmCross.ViewModels;

namespace AvanadeLogin.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            //Mvx.IoCProvider.RegisterType<ICalculationService, CalculationService>();

            RegisterAppStart<TipViewModel>();
        }
    }
}
