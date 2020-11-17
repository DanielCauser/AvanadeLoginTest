using System.Threading.Tasks;
using AvanadeLogin.Core.Models;

namespace AvanadeLogin.Core.Services
{
    public interface IAuthenticationService
    {
        Task<bool> AuthenticateUser(string username, string password);
        public void CreateUserAccount(UserAccountModel user);
    }
}
