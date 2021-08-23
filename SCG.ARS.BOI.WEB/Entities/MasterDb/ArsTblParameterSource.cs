using System;
using System.Collections.Generic;

namespace SCG.ARS.BOI.WEB.Entities.MasterDb
{
    public partial class ArsTblParameterSource
    {
        public int ParameterSourceId { get; set; }
        public string ParameterSourceName { get; set; }
        public bool? IsActive { get; set; }
    }
}
