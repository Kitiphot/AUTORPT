using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class PoddatUserlogin
    {
        public string Username { get; set; }
        public string Passwordx { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Mobileno { get; set; }
        public string Telephone { get; set; }
        public string Expiredate { get; set; }
        public string Usertype { get; set; }
        public string Usercode { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Position { get; set; }
        public byte[] Picture { get; set; }
        public byte[] Signature { get; set; }
        public Instant? Lastlogin { get; set; }
        public Instant? Forgetdate { get; set; }
        public string Resetcode { get; set; }
        public int Falsecount { get; set; }
        public string Createduser { get; set; }
        public Instant? Createddate { get; set; }
        public string Changeduser { get; set; }
        public Instant? Changeddate { get; set; }
        public bool Isactive { get; set; }
        public string Deviceid { get; set; }
        public int? Roleid { get; set; }
        public byte[] Passwordenc { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
