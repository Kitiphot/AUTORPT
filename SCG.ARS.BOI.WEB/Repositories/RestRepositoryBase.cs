using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Microsoft.Extensions.Options;

namespace SCG.ARS.BOI.WEB.Repositories
{
    public interface IRestRepositoryBase
    {
        ApiStore ApiStore { get; }
        HttpClient Client { get; }
    }

    public class RestRepositoryBase : IRestRepositoryBase
    {
        public RestRepositoryBase()
        {
            using var scope = ServiceLocator.GetScope();
            var opts = (IOptions<List<ApiStore>>)scope.ServiceProvider.GetService(typeof(IOptions<List<ApiStore>>));
            ApiStore = opts.Value.First(u => u.Id.Equals("Transhare")); // ID ?
            Client = new HttpClient { BaseAddress = new Uri(ApiStore.Url) };
            Client.DefaultRequestHeaders.Accept.Clear();

            foreach (var key in ApiStore.Headers.Keys)
            {
                Client.DefaultRequestHeaders.Add(key, ApiStore.Headers[key]);
            }
        }

        public ApiStore ApiStore { get; }
        public HttpClient Client { get; }
    }
}