using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Security.Model
{
    public class AccessTokenModel
    {
        public string Token { get; set; }
        public string Route { get; set; }
        public string SourceSystem { get; set; }
    }
}
