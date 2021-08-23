namespace SCG.ARS.BOI.WEB.ViewModels
{
    using System.Collections.Generic;
    using System.Security.Claims;

    public class ProfileViewModel
    {
        public string Name { get; set; }
        public IEnumerable<Claim> Claims { get; set; }
    }
}