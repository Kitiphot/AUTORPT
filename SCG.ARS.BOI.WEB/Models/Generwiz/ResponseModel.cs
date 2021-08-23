using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.GENZ.Models
{
    public class ResponseModel
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public string DocumentNo { get; set; }
        public bool Success { get { return Status == "S"; } }
        public ResponseModel()
        {
            Status = "E";
            //Message = "An error occurred. Please try again later.";
            Message = "";
        }
    }
}
