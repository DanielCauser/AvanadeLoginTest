using System;
using AvanadeLogin.Core.Models;

namespace AvanadeLogin.Core.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public bool AuthenticateUser(string username, string password)
        {
            Console.WriteLine($"Signed In: {username}, {password}");
            return true;
        }

        public void CreateUserAccount(UserAccountModel user)
        {
            
        }
    }
}
