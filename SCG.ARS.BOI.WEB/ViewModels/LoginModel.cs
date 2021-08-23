using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SCG.ARS.BOI.WEB.ViewModels {
    public class LoginModel {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}