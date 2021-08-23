using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using NLog;
using Npgsql;
using SCG.ARS.BOI.WEB.Configuration;
using SCG.ARS.BOI.WEB.Entities.MasterDb;

namespace SCG.ARS.BOI.WEB.Repositories
{
    public class LogRepository : ILogRepository
    {
        static Logger logger = LogManager.GetCurrentClassLogger();
        private ConnectionStrings _connections;

        private readonly MasterContext _masterContext;
        public LogRepository(IConfiguration configuration,
          IOptions<ConnectionStrings> connections,
          MasterContext masterContext)
        {
            _connections = connections.Value;
            _masterContext = masterContext;
        }

        internal IDbConnection ARSConnection
        {
            get
            {
                return new NpgsqlConnection(_connections.ARSConnection);
            }
        }

        public List<Logs> GetLogs(DateTime? created_date, string level)
        {
            var data = _masterContext.ArsTblLogs.Select(s => new Logs
            {
                Application = s.Application,
                Logged = s.Logged,
                Level = s.Level,
                Message = s.Message,
                Logger = s.Logger,
                Callsite = s.Callsite,
                Exception = s.Exception
            }).ToList();

            return data;
        }

        public Task<(bool, string)> ClearLog()
        {
            var status = false;
            var message = string.Empty;

            try
            {
                using (IDbConnection dbConnection = ARSConnection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Execute("Truncate master.ars_tbl_logs;", commandType: CommandType.Text);
                    status = true;
                    message = "Delete data Successful!";
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                message = ex.Message;

            }

            return Task.FromResult((status, message));
        }
    }
}