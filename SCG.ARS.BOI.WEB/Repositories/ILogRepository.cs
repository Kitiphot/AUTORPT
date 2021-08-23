using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SCG.ARS.BOI.WEB.Entities.MasterDb;

namespace SCG.ARS.BOI.WEB.Repositories
{
    public interface ILogRepository
    {
        List<Logs> GetLogs(DateTime? created_date, string level);
        Task<(bool, string)> ClearLog();
    }
}