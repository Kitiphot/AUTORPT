namespace SCG.ARS.BOI.WEB.ViewModels {
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel;

    public class LoginViewModel {
        [Required]
        [DisplayName ("User name")]
        public string UserName { get; set; }

        [Required]
        [DisplayName ("Password")]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}