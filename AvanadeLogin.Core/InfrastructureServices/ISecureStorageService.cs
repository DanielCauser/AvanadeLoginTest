using System.Threading.Tasks;

namespace AvanadeLogin.Core.InfrastructureServices
{
    public interface ISecureStorageService
    {
        Task Remove(string key);
        Task Set(string key, string item);
        Task Set(string key, object item);
        Task<string> Get(string key);
        Task<T> Get<T>(string key) where T : new();
    }
}
