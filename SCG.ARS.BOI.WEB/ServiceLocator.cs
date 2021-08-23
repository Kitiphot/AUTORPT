using Microsoft.Extensions.DependencyInjection;
using System;

namespace SCG.ARS.BOI.WEB
{
    /// <summary>
    /// <see cref="https://www.davidezoccarato.cloud/resolving-instances-with-asp-net-core-di-in-static-classes/"/> 
    /// </summary>
    public class ServiceLocator
    {
        internal static IServiceProvider _provider = null;

        /// <summary>
        /// Configure ServiceLocator with full serviceProvider
        /// </summary>
        /// <param name="provider"></param>
        public static void Configure(IServiceProvider provider)
        {
            _provider = provider;
        }

        /// <summary>
        /// Create a scope where use this ServiceLocator
        /// </summary>
        /// <param name="provider"></param>
        /// <returns></returns>
        public static IServiceScope GetScope(IServiceProvider provider = null)
        {
            return (provider ?? _provider)
                .GetRequiredService<IServiceScopeFactory>()
                .CreateScope();
        }
    }
}
