using System;
using System.Threading.Tasks;
using AvanadeLogin.Core.Models;

namespace AvanadeLogin.Core.Services
{
    public interface IUserAccountService
    {
        Task CreateUserAccount(UserAccountModel user);
    }
}
