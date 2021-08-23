using System;
using System.Collections.Generic;

namespace SCG.ARS.BOI.WEB.Entities.MasterDb
{
    public partial class ArsTblDataType
    {
        public int DataTypeId { get; set; }
        public string DataTypeName { get; set; }
        public bool? IsActive { get; set; }
    }
}
