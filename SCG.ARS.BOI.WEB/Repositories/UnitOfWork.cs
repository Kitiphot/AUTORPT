using Microsoft.EntityFrameworkCore;

namespace SCG.ARS.BOI.WEB.Repositories {
    public class UnitOfWork : IUnitOfWork {
        public DbContext Context { get; }

        public UnitOfWork (DbContext context) {
            Context = context;
        }
        public void Commit () {
            Context.SaveChanges ();
        }

        public void Dispose () {
            Context.Dispose ();

        }
    }
}