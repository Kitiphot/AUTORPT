using Microsoft.EntityFrameworkCore;

namespace SCG.ARS.BOI.WEB.Repositories
{
    public interface IUnitOfWork
    {
        DbContext Context { get;  }
        void Commit();
    }
}