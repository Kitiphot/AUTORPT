using System;
using System.Collections.Generic;

namespace SCG.ARS.BOI.WEB.Entities.MasterDb
{
    public partial class ArsTblParameterType
    {
        public int ParameterTypeId { get; set; }
        public string ParameterTypeName { get; set; }
        public bool? IsActive { get; set; }
    }
}
