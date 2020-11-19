using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Essentials;

namespace AvanadeLogin.Core.InfrastructureServices
{
    /// <summary>
    /// In theory, this service should save the user data to the phone local secure storage.
    /// However, some folk were having trouble Provisioning given that for that the app needs to use entitlements.plist file.
    /// Therefore, I will switch this service to save/get data from and to the app memory.
    /// </summary>
    public class SecureStorageService : ISecureStorageService
    {
        private static IDictionary<string, string> LocalSecureStorageSimulation;

        public SecureStorageService()
        {
            LocalSecureStorageSimulation = new Dictionary<string, string>();
        }

        public Task<string> Get(string key)
        {
            LocalSecureStorageSimulation.TryGetValue(key, out string value);
            return Task.FromResult(value);
        }

        public Task<T> Get<T>(string key) where T : new()
        {
            LocalSecureStorageSimulation.TryGetValue(key, out string value);
            return !string.IsNullOrEmpty(value) ? Task.FromResult(JsonConvert.DeserializeObject<T>(value)) : Task.FromResult(default(T));
        }

        public Task Remove(string key)
        {
            throw new NotImplementedException();
        }

        public Task Set(string key, string item)
        {
            throw new NotImplementedException();
        }

        public async Task Set(string key, object item)
        {
            var exists = await Get(key);

            var save = JsonConvert.SerializeObject(item);

            if (!string.IsNullOrEmpty(exists))
            {
                LocalSecureStorageSimulation[key] = save;
                return;
            }

            LocalSecureStorageSimulation.Add(key, save);
            return;
        }
    }
}
