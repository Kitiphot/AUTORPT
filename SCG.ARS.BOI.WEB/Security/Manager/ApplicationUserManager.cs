using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SCG.ARS.BOI.WEB.Security.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Security.Manager
{
    public class ApplicationUserManager : UserManager<ApplicationUser>
    {
        ApplicationUserManager(IUserStore<ApplicationUser> store,
                                       IOptions<IdentityOptions> optionsAccessor,
                                       IPasswordHasher<ApplicationUser> passwordHasher,
                                       IEnumerable<IUserValidator<ApplicationUser>> userValidators,
                                       IEnumerable<IPasswordValidator<ApplicationUser>> passwordValidators,
                                       ILookupNormalizer keyNormalizer,
                                       IdentityErrorDescriber errors,
                                       IServiceProvider services, ILogger<UserManager<ApplicationUser>> logger)
           : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {

        }
    }
}
