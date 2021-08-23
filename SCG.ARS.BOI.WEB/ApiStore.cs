using System.Collections.Generic;

namespace SCG.ARS.BOI.WEB
{
    public class ApiStore
    {
        public ApiStore()
        {
            Headers = new Dictionary<string, string>();
        }

        public string Id { get; set; }
        public string Url { get; set; }
        public IDictionary<string, string> Headers { get; set; }
    }
}
