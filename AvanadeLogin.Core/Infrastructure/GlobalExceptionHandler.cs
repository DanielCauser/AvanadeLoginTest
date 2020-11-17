using System;
using System.Collections.Generic;
using System.Linq;
using AvanadeLogin.Core.Infrastructure.Exceptions;
using AvanadeLogin.Core.Services;

namespace AvanadeLogin.Core.Infrastructure
{
    public class GlobalExceptionHandler : IObserver<Exception>
    {
        readonly IDialogueService _dialogs;

        readonly IList<string> KnownExceptionMap = new List<string>
            {
                nameof(UserAccounException)
            };

        public GlobalExceptionHandler(IDialogueService dialogs)
        {
            _dialogs = dialogs;
        }

        public void OnCompleted()
        {

        }

        public void OnError(Exception error)
        {
            
        }

        public void OnNext(Exception value)
        {
            //Handle Known exceptions
            if (KnownExceptionMap.Any(x => x == value.GetType().Name))
                _dialogs.ShowInformation(value.Message);
            else
                _dialogs.ShowError(value.Message);
        }
    }
}
