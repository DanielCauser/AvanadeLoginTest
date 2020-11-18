using System;
using Acr.UserDialogs;

namespace AvanadeLogin.Core.InfrastructureServices
{
    public class DialogueService : IDialogueService
    {
        private readonly IUserDialogs _userDialogs;

        public DialogueService(IUserDialogs userDialogs)
        {
            _userDialogs = userDialogs;
        }

        public void ShowInformation(string message)
        {
            _userDialogs.Toast(message);
        }

        public void ShowError(string message)
        {
            _userDialogs.Alert(message, "An error occured.", "Ok");
        }

        public void ShowValidationError(string message)
        {
            _userDialogs.Alert(message, "Validation errors occured.", "Ok");
        }
    }
}
