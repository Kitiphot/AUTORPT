using System;
using System.Collections.Generic;

namespace SCG.ARS.BOI.WEB.Entities.MasterDb
{
    public partial class ArsTblCustomer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public bool? IsActive { get; set; }
    }
}
