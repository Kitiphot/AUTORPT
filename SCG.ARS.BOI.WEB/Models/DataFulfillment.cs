using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Models
{
    public class DataFulfillment
    {
        public class ReturnResult
        {
            public string Data { get; set; }
            public Exception Error { get; set; } = null;
            public bool IsComplete
            {
                get {
                    return Error == null;
                }
            }
        }
        public class ProxyParam
        {
            public string Service { get; set; }
            public string Data { get; set; }
        }
    }
}
