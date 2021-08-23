using System;
using System.Collections.Generic;

namespace SCG.ARS.BOI.WEB.Entities.MasterDb
{
    public partial class ArsTblColumn
    {
        public int Columnid { get; set; }
        public int Tableid { get; set; }
        public int Schemaid { get; set; }
        public string Columnname { get; set; }
        public string Columntype { get; set; }
    }
}
