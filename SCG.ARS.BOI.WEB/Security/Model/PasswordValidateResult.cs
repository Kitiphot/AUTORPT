using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Security.Model
{
    public class PasswordValidateResult
    {
        public bool IsValid { get; set; }
        public List<string> Errors { get; set; }
    }
}
