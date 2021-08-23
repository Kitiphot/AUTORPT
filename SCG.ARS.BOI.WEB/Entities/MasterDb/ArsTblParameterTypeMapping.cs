using System;
using System.Collections.Generic;

namespace SCG.ARS.BOI.WEB.Entities.MasterDb
{
    public partial class ArsTblParameterTypeMapping
    {
        public int ParameterTypeMappingId { get; set; }
        public string ParameterDefaultValue { get; set; }
        public int ParameterDataTypeId { get; set; }
        public string ParameterCustomValue { get; set; }
        public string ParameterSourceTarget { get; set; }
        public string ParameterSourceColumn { get; set; }
        public int? ParameterSourceId { get; set; }
        public bool? IsActive { get; set; }
    }
}
