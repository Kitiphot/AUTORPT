using Microsoft.EntityFrameworkCore;

namespace SCG.ARS.BOI.WEB.Helpers {
    public class ApplicationContext : DbContext {
        public ApplicationContext (DbContextOptions options) : base (options) { }

        //public DbSet<Users> Users { get; set; }
    }
}