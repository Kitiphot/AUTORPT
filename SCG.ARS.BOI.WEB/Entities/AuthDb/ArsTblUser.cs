using System;
using System.Collections.Generic;

namespace SCG.ARS.BOI.WEB.Entities.AuthDb
{
    public partial class ArsTblUser
    {
        public int Userid { get; set; }
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Emailaddress { get; set; }
    }
}
