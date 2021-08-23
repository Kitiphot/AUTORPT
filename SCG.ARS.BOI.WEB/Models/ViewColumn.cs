using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Models
{
    public class ViewColumn
    {
        public string data { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public Boolean? autoWidth { get; set; }
        public string className { get; set; }
        public Boolean? orderable { get; set; }

    }
}
