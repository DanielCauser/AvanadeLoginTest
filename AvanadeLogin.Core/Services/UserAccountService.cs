using System;
using System.Threading.Tasks;
using AvanadeLogin.Core.InfrastructureServices;
using AvanadeLogin.Core.InfrastructureServices.Exceptions;
using AvanadeLogin.Core.Models;

namespace AvanadeLogin.Core.Services
{
    public class UserAccountService : IUserAccountService
    {
        private readonly ISecureStorageService _secureStorageService;

        public UserAccountService(ISecureStorageService secureStorageService)
        {
            _secureStorageService = secureStorageService;
        }

        public async Task<bool> AuthenticateUser(string username, string password)
        {
            var user = await _secureStorageService.Get<UserAccountModel>(username);
            if (user is null)
                throw new UserAccounException("The acount does not exist.");

            if (user.Password != password)
                throw new UserAccounException("Password incorrect.");

            return true;
        }

        public Task CreateUserAccount(UserAccountModel user)
        {
            user.Validade();
            return _secureStorageService.Set(user.Username, user);
        }
    }
}
