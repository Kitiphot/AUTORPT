using SCG.ARS.BOI.WEB.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Security
{
    public static class SecurityHelpers
    {
        public static string ToHash(this string input)
        {
            using System.Security.Cryptography.SHA512 encrypt = System.Security.Cryptography.SHA512.Create();
            byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = encrypt.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            sb.Append(Convert.ToBase64String(hashBytes));
            return sb.ToString();
        }

        public static bool IsAllow(this ClaimsPrincipal cp, ScreenID screen, Permission perm)
        {
            return cp.FindAll($"PM_{perm.ToString()}").Any(c => c.Value.Equals(screen.ToString(), StringComparison.InvariantCultureIgnoreCase)) ||
                cp.Identity.Name == SecurityHelpers.GetAdminUser() ||
                cp.IsInRole(SecurityHelpers.GetAdminRole());
        }

        public static bool IsAllow(this ClaimsPrincipal cp, string screenID, Permission perm)
        {
            return cp.FindAll($"PM_{perm.ToString()}").Any(c => c.Value.Equals(screenID, StringComparison.InvariantCultureIgnoreCase)) ||
                cp.Identity.Name == SecurityHelpers.GetAdminUser() ||
                cp.IsInRole(SecurityHelpers.GetAdminRole());
        }
        public static string GetAdminUser()
        {
            return "admin";
        }
        public static string GetAdminRole()
        {
            return "Administrator";
        }
    }
}
