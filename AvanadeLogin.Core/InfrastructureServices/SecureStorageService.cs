using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Essentials;

namespace AvanadeLogin.Core.InfrastructureServices
{
    public class SecureStorageService : ISecureStorageService
    {
        public Task<string> Get(string key)
        {
            return SecureStorage.GetAsync(key);
        }

        public async Task<T> Get<T>(string key) where T : new()
        {
            var item = await SecureStorage.GetAsync(key);
            
            return !string.IsNullOrEmpty(item) ? JsonConvert.DeserializeObject<T>(item) : default(T);
        }

        public Task Remove(string key)
        {
            throw new NotImplementedException();
        }

        public Task Set(string key, string item)
        {
            return SecureStorage.SetAsync(key, item);
        }

        public Task Set(string key, object item)
        {
            var save = JsonConvert.SerializeObject(item);
            return SecureStorage.SetAsync(key, save);
        }
    }
}
