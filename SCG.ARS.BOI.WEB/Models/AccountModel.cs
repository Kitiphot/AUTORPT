using System;
using System.Collections.Generic;

namespace SCG.ARS.BOI.WEB.Models
{
    public partial class AccountModel
    {
        public int AccountId { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public string AccountFullName { get; set; }
        public int SortingNo { get; set; }
        public bool DisplayFlag { get; set; }
        public string CreateUserCode { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string UpdateUserCode { get; set; }
        public DateTime UpdateDateTime { get; set; }
    }
}
