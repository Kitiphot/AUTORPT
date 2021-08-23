using System;
using System.Collections.Generic;

namespace SCG.ARS.BOI.WEB.Entities.MasterDb
{
    public partial class ArsTblEmailaddress
    {
        public int EmailId { get; set; }
        public string EmailAddress { get; set; }
        public bool IsDefault { get; set; }
    }
}
