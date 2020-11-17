using System;
namespace AvanadeLogin.Core.Services
{
    public interface IDialogueService
    {
        void ShowInformation(string message);
        void ShowError(string message);
        void ShowValidationError(string message);
    }
}
