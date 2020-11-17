using System;
using System.Threading.Tasks;
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

        public Task CreateUserAccount(UserAccountModel user)
        {
            throw new NotImplementedException();
        }
    }
}
