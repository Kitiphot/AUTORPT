using Newtonsoft.Json;

namespace SCG.ARS.BOI.WEB.Configuration
{
    public class NotifySetting
    {
         public const string Section = "Line:NotifySetting";
         [JsonProperty("Line:NotifySetting:Url")]
         public string Url { get; set; }
         [JsonProperty("Line:NotifySetting:Authorization")]
         public string Authorization { get; set; }
    }
}