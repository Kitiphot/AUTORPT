// ----------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.
// ----------------------------------------------------------------------------

namespace SCG.ARS.BOI.WEB.Services {
    //using AppOwnsData.Models;
    using Microsoft.Extensions.Options;
    using Microsoft.Identity.Client;
    using System;
    using System.Linq;
    using System.Security;
    using SCG.ARS.BOI.WEB.Configuration;

    public class AadService
    {
        private readonly PowerBISetting setting;

        public AadService(IOptions<PowerBISetting> setting)  
        {
            this.setting = setting.Value;
        }

        /// <summary>
        /// Generates and returns Access token
        /// </summary>
        /// <returns>AAD token</returns>
        public string GetAccessToken()
        {
            AuthenticationResult authenticationResult = null;
            if (setting.AuthenticationType.Equals("masteruser", StringComparison.InvariantCultureIgnoreCase)) {
                // Create a public client to authorize the app with the AAD app
                //IPublicClientApplication clientApp = PublicClientApplicationBuilder.Create(setting.ApplicationId.ToString()).WithAuthority(setting.AuthorityUrl).Build();
                var authUri = new Uri(setting.AuthorityUrl, UriKind.Absolute);
                IPublicClientApplication clientApp = PublicClientApplicationBuilder.Create(setting.ApplicationId.ToString()).WithAuthority(authUri).Build();
                var userAccounts = clientApp.GetAccountsAsync().Result;
                try {
                    // Retrieve Access token from cache if available
                    authenticationResult = clientApp.AcquireTokenSilent(setting.Scope, userAccounts.FirstOrDefault()).ExecuteAsync().Result;
                } catch (MsalUiRequiredException) {
                    SecureString password = new SecureString();
                    foreach (var key in setting.Password) {
                        password.AppendChar(key);
                    }
                    try {
                        authenticationResult = clientApp.AcquireTokenByUsernamePassword(setting.Scope, setting.UserName, password).ExecuteAsync().Result;
                    } catch (Exception e) {
                        string s = e.Message;
                    }
                } catch (Exception e) {
                    SecureString password = new SecureString();
                    foreach (var key in setting.Password) {
                        password.AppendChar(key);
                    }
                    try {
                        authenticationResult = clientApp.AcquireTokenByUsernamePassword(setting.Scope, setting.UserName, password).ExecuteAsync().Result;
                    } catch (AggregateException ae) {
                        //ae.Handle((x) =>
                        //{
                        //    if (x is UnauthorizedAccessException) {
                        //        return true;
                        //    }
                        //    return false;
                        //});
                        throw ae.Flatten().InnerException;
                    }
                }
            }
            // Service Principal auth is the recommended by Microsoft to achieve App Owns Data Power BI embedding
            else if (setting.AuthenticationType.Equals("serviceprincipal", StringComparison.InvariantCultureIgnoreCase)) {
                // For app only authentication, we need the specific tenant id in the authority url
                var tenantSpecificUrl = setting.AuthorityUrl.Replace("organizations", setting.TenantId);

                // Create a confidential client to authorize the app with the AAD app
                IConfidentialClientApplication clientApp = ConfidentialClientApplicationBuilder
                                                                                .Create(setting.ApplicationId.ToString())
                                                                                .WithClientSecret(setting.ClientSecret)
                                                                                .WithAuthority(tenantSpecificUrl)
                                                                                .Build();
                // Make a client call if Access token is not available in cache
                authenticationResult = clientApp.AcquireTokenForClient(setting.Scope).ExecuteAsync().Result;
            }
            
            return authenticationResult?.AccessToken;
        }
    }
}
