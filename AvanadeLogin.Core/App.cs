﻿using System;
using Acr.UserDialogs;
using AvanadeLogin.Core.InfrastructureServices;
using AvanadeLogin.Core.Services;
using AvanadeLogin.Core.ViewModels;
using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using ReactiveUI;
using Xamarin.Essentials;

namespace AvanadeLogin.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.IoCProvider.RegisterSingleton<ISecureStorageService>(new SecureStorageService());
            Mvx.IoCProvider.RegisterType<IUserAccountService, UserAccountService>();
            Mvx.IoCProvider.RegisterType<IDialogueService, DialogueService>();
            Mvx.IoCProvider.LazyConstructAndRegisterSingleton(typeof(IUserDialogs), () => UserDialogs.Instance);
            var dialogue = Mvx.IoCProvider.Resolve<IDialogueService>();
            RxApp.DefaultExceptionHandler = new GlobalExceptionHandler(dialogue);

            RegisterCustomAppStart<AvanadeLoginAppStart>();
        }
    }
}
