using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SCG.ARS.BOI.WEB.Services;
using SCG.ARS.BOI.WEB.Models;
using SCG.ARS.BOI.WEB.ViewModels;
using SCG.ARS.BOI.WEB.Configuration;
using Microsoft.PowerBI.Api.V2;
using Microsoft.PowerBI.Api.V2.Models;
using Microsoft.Identity.Client;
using Microsoft.Rest;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Security;
using System.Text.Json;
using Microsoft.Extensions.Options;
using SCG.ARS.BOI.WEB.Repositories;

namespace SCG.ARS.BOI.WEB.Controllers {
	public class PowerBIController : Controller {
		
		public IActionResult Index() {
			return View();
		}
		
		public IActionResult Embed(string id) {

			var model = repo.GetPowerBI(id);

			return View(model);
		}

		public IActionResult Power_BI_01() {
			return View();
		}

		public IActionResult Power_BI_02() {
			return View();
		}
		//public async Task<ActionResult> Index([FromServices] PowerBISetting powerBISettings) {
		//    var result = new PowerBIEmbedConfigModel { Username = powerBISettings.UserName };
		//    var accessToken = //await GetPowerBIAccessToken(powerBISettings);
		//        GetAccessToken(powerBISettings);
		//    var tokenCredentials = new TokenCredentials(accessToken, "Bearer");

		//    using (var client = new PowerBIClient(new Uri(powerBISettings.ApiUrl), tokenCredentials)) {
		//        var workspaceId = powerBISettings.WorkspaceId.ToString();
		//        var reportId = powerBISettings.ReportId.ToString();
		//        var report = await client.Reports.GetReportInGroupAsync(workspaceId, reportId);
		//        var generateTokenRequestParameters = new GenerateTokenRequest(accessLevel: "view");
		//        var tokenResponse = await client.Reports.GenerateTokenAsync(workspaceId, reportId, generateTokenRequestParameters);

		//        result.EmbedToken = tokenResponse;
		//        result.EmbedUrl = report.EmbedUrl;
		//        result.Id = report.Id;
		//    }

		//    return View(result);
		//}

		private readonly PbiEmbedService pbiEmbedService;
		//private readonly IOptions<AzureAd> azureAd;
		//private readonly IOptions<PowerBI> powerBI;
		private readonly PowerBISetting setting;
		private readonly IMasterRepository repo;

		public PowerBIController(PbiEmbedService pbiEmbedService, IOptions<PowerBISetting> setting, IMasterRepository repo) {
			this.pbiEmbedService = pbiEmbedService;
			//this.azureAd = azureAd;
			//this.powerBI = powerBI;
			this.setting = setting.Value;
			this.repo = repo;
		}


		/// <summary>
		/// Returns Embed token, Embed URL, and Embed token expiry to the client
		/// </summary>
		/// <returns>JSON containing parameters for embedding</returns>
		[HttpPost]
		public string GetEmbedInfo(string reportId) {
			try {
				//// Validate whether all the required configurations are provided in appsettings.json
				//string configValidationResult = ConfigValidatorService.ValidateConfig(azureAd, powerBI);
				//if (configValidationResult != null) {
				//    HttpContext.Response.StatusCode = 400;
				//    return configValidationResult;
				//}

				PowerBIEmbedConfigModel embedParams = pbiEmbedService.GetEmbedParams(setting.WorkspaceId.GetValueOrDefault(), new Guid(reportId)/*setting.ReportId*/);
				return JsonSerializer.Serialize<PowerBIEmbedConfigModel>(embedParams);
			} catch (Exception ex) {
				HttpContext.Response.StatusCode = 500;
				return ex.Message + "\n\n" + ex.StackTrace;
			}
		}

		private string GetAccessToken(PowerBISetting powerBISettings) {
			AuthenticationResult authenticationResult = null;
			if (powerBISettings.AuthenticationType.Equals("masteruser", StringComparison.InvariantCultureIgnoreCase)) {
				// Create a public client to authorize the app with the AAD app
				IPublicClientApplication clientApp = PublicClientApplicationBuilder.Create(powerBISettings.ApplicationId.ToString()).WithAuthority(powerBISettings.AuthorityUrl).Build();
				var userAccounts = clientApp.GetAccountsAsync().Result;
				try {
					// Retrieve Access token from cache if available
					authenticationResult = clientApp.AcquireTokenSilent(powerBISettings.Scope, userAccounts.FirstOrDefault()).ExecuteAsync().Result;
				//} catch (MsalUiRequiredException) {
				} catch (Exception e) {
					SecureString password = new SecureString();
					foreach (var key in powerBISettings.Password) {
						password.AppendChar(key);
					}
					authenticationResult = clientApp.AcquireTokenByUsernamePassword(powerBISettings.Scope, powerBISettings.UserName, password).ExecuteAsync().Result;
				} 
			}

			// Service Principal auth is the recommended by Microsoft to achieve App Owns Data Power BI embedding
			else if (powerBISettings.AuthenticationType.Equals("serviceprincipal", StringComparison.InvariantCultureIgnoreCase)) {
				// For app only authentication, we need the specific tenant id in the authority url
				var tenantSpecificUrl = powerBISettings.AuthorityUrl.Replace("organizations", powerBISettings.TenantId);

				// Create a confidential client to authorize the app with the AAD app
				IConfidentialClientApplication clientApp = ConfidentialClientApplicationBuilder
																				.Create(powerBISettings.ApplicationId.ToString())
																				.WithClientSecret(powerBISettings.ClientSecret)
																				.WithAuthority(tenantSpecificUrl)
																				.Build();
				// Make a client call if Access token is not available in cache
				authenticationResult = clientApp.AcquireTokenForClient(powerBISettings.Scope).ExecuteAsync().Result;
			}

			return authenticationResult.AccessToken;
		}

		private async Task<string> GetPowerBIAccessToken(PowerBISetting powerBISettings) {
			using var client = new HttpClient();
			var form = new Dictionary<string, string>() {
				["grant_type"] = "password",
				["resource"] = powerBISettings.ResourceUrl,
				["username"] = powerBISettings.UserName,
				["password"] = powerBISettings.Password,
				["client_id"] = powerBISettings.ApplicationId.ToString(),
				//["client_secret"] = powerBISettings.ApplicationSecret,
				["scope"] = "openid"
			};

			client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-www-form-urlencoded");

			using var formContent = new FormUrlEncodedContent(form);
			using var response = await client.PostAsync(powerBISettings.AuthorityUrl, formContent);
			var body = await response.Content.ReadAsStringAsync();
			var jsonBody = JObject.Parse(body);

			var errorToken = jsonBody.SelectToken("error");
			if (errorToken != null) {
				throw new Exception(errorToken.Value<string>());
			}

			return jsonBody.SelectToken("access_token").Value<string>();
		}
	}

	public class PowerBIController_bak : Controller {
		private readonly IPowerBIEmbedService m_embedService;

		public PowerBIController_bak() {
			m_embedService = new PowerBIEmbedService();
		}

		public async Task<ActionResult> Index(string username, string roles) {
			var embedResult = await m_embedService.EmbedReport(username, roles);
			if (embedResult) {
				return View(m_embedService.EmbedConfig);
			} else {
				return View(m_embedService.EmbedConfig);
			}
		}
	}

}
