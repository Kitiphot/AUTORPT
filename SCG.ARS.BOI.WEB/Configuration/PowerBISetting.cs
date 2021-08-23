using Newtonsoft.Json;
using System;

namespace SCG.ARS.BOI.WEB.Configuration {
    public class PowerBISetting {
        public const string Section = "PowerBI";

        // Can be set to 'MasterUser' or 'ServicePrincipal'
        [JsonProperty("PowerBI:AuthenticationType")]
        public string AuthenticationType { get; set; }

        // Client Id (Application Id) of the AAD app
        [JsonProperty("PowerBI:ApplicationId")]
        public Guid ApplicationId { get; set; }

        [JsonProperty("PowerBI:ApplicationSecret")]
        public string ApplicationSecret { get; set; }

        [JsonProperty("PowerBI:ReportId")]
        public Guid ReportId { get; set; }

        [JsonProperty("PowerBI:WorkspaceId")]
        public Guid? WorkspaceId { get; set; }

        // URL used for initiating authorization request
        [JsonProperty("PowerBI:AuthorityUrl")]
        public string AuthorityUrl { get; set; }

        [JsonProperty("PowerBI:ResourceUrl")]
        public string ResourceUrl { get; set; }

        [JsonProperty("PowerBI:ApiUrl")]
        public string ApiUrl { get; set; }

        [JsonProperty("PowerBI:EmbedUrlBase")]
        public string EmbedUrlBase { get; set; }

        // Master user email address. Required only for MasterUser authentication mode.
        [JsonProperty("PowerBI:UserName")]
        public string UserName { get; set; }

        // Master user email password. Required only for MasterUser authentication mode.
        [JsonProperty("PowerBI:Password")]
        public string Password { get; set; }

        // Scope of AAD app. Use the below configuration to use all the permissions provided in the AAD app through Azure portal.
        [JsonProperty("PowerBI:Scope")]
        public string[] Scope { get; set; }

        // Id of the Azure tenant in which AAD app is hosted. Required only for Service Principal authentication mode.
        [JsonProperty("PowerBI:TenantId")]
        public string TenantId { get; set; }

        // Client Secret (App Secret) of the AAD app. Required only for ServicePrincipal authentication mode.
        [JsonProperty("PowerBI:ClientSecret")]
        public string ClientSecret { get; set; }
    }
}
