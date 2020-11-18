using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AvanadeLogin.Core.InfrastructureServices.Exceptions;
using AvanadeLogin.Core.Services;
using FluentValidation;

namespace AvanadeLogin.Core.InfrastructureServices
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
            else if(value is ValidationException exception)
                _dialogs.ShowValidationError(FormatFluentValidatorExceptions(exception));
            else
                _dialogs.ShowError(value.Message);
        }


        string FormatFluentValidatorExceptions(ValidationException exception)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in exception.Errors)
            {
                sb.AppendLine($"{item.PropertyName}, {item.ErrorMessage}");
            }

            return sb.ToString();
        }
    }
}
