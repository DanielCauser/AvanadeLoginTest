using System;
namespace AvanadeLogin.Core.InfrastructureServices.Exceptions
{
    public class UserAccounException : Exception
    {
        public UserAccounException(string message) : base(message)
        {
        }
    }
}
