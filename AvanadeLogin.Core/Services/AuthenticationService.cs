using System;
using System.Threading.Tasks;
using AvanadeLogin.Core.Infrastructure.Exceptions;
using AvanadeLogin.Core.Models;

namespace AvanadeLogin.Core.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly ISecureStorageService _secureStorageService;

        public AuthenticationService(ISecureStorageService secureStorageService)
        {
            _secureStorageService = secureStorageService;
        }

        public async Task<bool> AuthenticateUser(string username, string password)
        {
            var user = await _secureStorageService.Get<UserAccountModel>(username);
            if(user is null)
                throw new UserAccounException("The acount does not exist.");

            if (user.Password != password)
                throw new UserAccounException("Password incorrect.");

            return true;
        }

        public void CreateUserAccount(UserAccountModel user)
        {
            
        }
    }
}
