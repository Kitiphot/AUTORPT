using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SCG.ARS.BOI.WEB.Security.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Security.Store
{
    public class ApplicationUserStore : UserStore<ApplicationUser>
    {
        private SecurityDbContext db { get; set; }
        public ApplicationUserStore(DbContext context, IdentityErrorDescriber describer = null) : base(context, describer)
        {
            db = context as SecurityDbContext;
        }
    }
}
