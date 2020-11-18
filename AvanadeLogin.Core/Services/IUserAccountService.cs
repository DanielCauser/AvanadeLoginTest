using System;
using System.Threading.Tasks;
using AvanadeLogin.Core.Models;

namespace AvanadeLogin.Core.Services
{
    public interface IUserAccountService
    {
        Task<bool> AuthenticateUser(string username, string password);
        Task CreateUserAccount(UserAccountModel user);
    }
}
