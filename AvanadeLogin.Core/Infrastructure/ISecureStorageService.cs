using System.Threading.Tasks;

namespace AvanadeLogin.Core.Services
{
    public interface ISecureStorageService
    {
        Task Remove(string key);
        Task Set(string key, string item);
        Task<string> Get(string key);

        Task<T> Get<T>(string key) where T : new();
        Task Set<T>(string key, T item) where T : new();
        Task Remove<T>(string key) where T : new();
    }
}
