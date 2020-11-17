using AvanadeLogin.Core.Models;

namespace AvanadeLogin.Core.Services
{
    public interface IAuthenticationService
    {
        bool AuthenticateUser(string username, string password);
        public void CreateUserAccount(UserAccountModel user);
    }
}
