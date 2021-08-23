using SCG.ARS.BOI.WEB.Models;

namespace SCG.ARS.BOI.WEB.Services {
    public interface IAuthenticationService {
        Users Login (string username, string password);
    }
}