using System;
namespace AvanadeLogin.Core.InfrastructureServices
{
    public interface IDialogueService
    {
        void ShowInformation(string message);
        void ShowError(string message);
        void ShowValidationError(string message);
    }
}
