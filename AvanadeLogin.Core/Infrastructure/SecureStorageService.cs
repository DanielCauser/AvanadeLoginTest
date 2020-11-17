using System;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace AvanadeLogin.Core.Services
{
    public class SecureStorageService : ISecureStorageService
    {
        public Task<string> Get(string key)
        {
            throw new NotImplementedException();
        }

        public Task<T> Get<T>(string key) where T : new()
        {
            throw new NotImplementedException();
        }

        public Task Remove(string key)
        {
            throw new NotImplementedException();
        }

        public Task Remove<T>(string key) where T : new()
        {
            throw new NotImplementedException();
        }

        public Task Set(string key, string item)
        {
            throw new NotImplementedException();
        }

        public Task Set<T>(string key, T item) where T : new()
        {
            throw new NotImplementedException();
        }
    }
}
