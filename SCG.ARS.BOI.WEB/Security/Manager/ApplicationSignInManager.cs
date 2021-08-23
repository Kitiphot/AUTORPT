using Microsoft.AspNetCore.Http;
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

    public class ApplicationSignInManager : SignInManager<ApplicationUser>
    {
        public ApplicationSignInManager(UserManager<ApplicationUser> userManager,
                                        IHttpContextAccessor contextAccessor,
                                        IUserClaimsPrincipalFactory<ApplicationUser> claimsFactory,
                                        IOptions<IdentityOptions> optionsAccessor,
                                        ILogger<SignInManager<ApplicationUser>> logger,
                                        Microsoft.AspNetCore.Authentication.IAuthenticationSchemeProvider schemes)
            : base(userManager, contextAccessor, claimsFactory, optionsAccessor, logger, schemes)
        {
        }

		// for .net core 3.0
		//public ApplicationSignInManager(UserManager<ApplicationUser> userManager,
		//								IHttpContextAccessor contextAccessor,
		//								IUserClaimsPrincipalFactory<ApplicationUser> claimsFactory,
		//								IOptions<IdentityOptions> optionsAccessor,
		//								ILogger<SignInManager<ApplicationUser>> logger,
		//								Microsoft.AspNetCore.Authentication.IAuthenticationSchemeProvider schemes,
		//								Microsoft.AspNetCore.Identity.IUserConfirmation<ApplicationUser> confirmation)
  //          : base(userManager, contextAccessor, claimsFactory, optionsAccessor, logger, schemes, confirmation)
  //      {
		//}
	}
}
