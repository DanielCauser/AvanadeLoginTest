using System;
using System.Collections.Generic;
using System.Linq;
using AvanadeLogin.Core.Infrastructure.AppExceptions;
using AvanadeLogin.Core.Services;

namespace AvanadeLogin.Core.Infrastructure
{
    public class GlobalExceptionHandler : IObserver<Exception>
    {
        readonly IDialogueService _dialogs;

        readonly IList<string> KnownExceptionMap = new List<string>
            {
                nameof(AccountDoesNotExistException)
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
            //Handle Known exceptions
            if (KnownExceptionMap.Any(x => x == error.GetType().ToString()))
                _dialogs.ShowInformation(error.Message);
            else
                _dialogs.ShowError(error.Message);
        }

        public void OnNext(Exception value)
        {

        }
    }
}
