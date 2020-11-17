using System;
namespace AvanadeLogin.Core.Infrastructure.AppExceptions
{
    public class AccountDoesNotExistException : Exception
    {
        public AccountDoesNotExistException(string message) : base(message)
        {
        }
    }
}
