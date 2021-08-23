using System;
using System.Diagnostics;
using System.IO;
namespace SCG.ARS.BOI.WEB.Services {
    using System.Collections.Generic;
    using System.Data;
    using System.Globalization;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using System;
    using Microsoft.AspNetCore.Http;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Options;
    using NLog;
    using Npgsql;
    using SCG.ARS.BOI.WEB.Helpers;
    using SCG.ARS.BOI.WEB.Models;
    using SCG.ARS.BOI.WEB.Configuration;

    public class DataService : IDataService {
        static Logger logger = LogManager.GetCurrentClassLogger ();
        private readonly IConfiguration _configuration;
        private readonly AppSetting _appsetting;
        //private readonly AdminSetting _supAdmin;
        //private readonly GLDataContext _dataContext;
        private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly string _glDataConnectionString;
        private readonly string _userCode;

        public DataService (IConfiguration configuration,
            IOptions<AppSetting> setting,
            IHttpContextAccessor httpContextAccessor
            //GLDataContext dataContext
        ) {
            _configuration = configuration;
            _appsetting = setting.Value;
            //_dataContext = dataContext;
            _glDataConnectionString = configuration.GetConnectionString ("GLDataConnection");
            _httpContextAccessor = httpContextAccessor;
            var httpContext = httpContextAccessor.HttpContext;
            var user = httpContext != null ? httpContext.User : null;
            _userCode = user != null ? user.FindFirst (ClaimTypes.Sid).Value != null ? user.FindFirst (ClaimTypes.Sid).Value : "" : "";
        }

        public async Task < (bool, DataTable, string) > ExecuteCommandReader (string commands) {
            var isSuccess = false;
            var list = new DataTable ();
            var message = string.Empty;
            try {
                using (NpgsqlConnection conn = new NpgsqlConnection (_glDataConnectionString)) {
                    conn.Open ();
                    NpgsqlCommand cmd = new NpgsqlCommand (commands, conn);
                    cmd.CommandTimeout = 300;
                    using (var reader = await cmd.ExecuteReaderAsync ()) {
                        list.Load (reader);
                    }
                    isSuccess = true;
                }
            } catch (Exception ex) {
                // NLog: catch any exception and log it.
                if (ex.InnerException != null) {
                    logger.Error (ex.InnerException, ex.InnerException.Message);
                    message = ex.InnerException.Message;
                } else {
                    logger.Error (ex, ex.Message);
                    message = ex.Message;
                }
            }

            var result = (isSuccess, list, message);
            return await Task.FromResult (result);
        }

        public async Task < (bool, Int32, string) > ExecuteCommandNoneQuery (string commands) {
            var isSuccess = false;
            var rowsaffect = 0;
            var message = string.Empty;
            try {
                using (NpgsqlConnection conn = new NpgsqlConnection (_glDataConnectionString)) {
                    conn.Open ();
                    NpgsqlCommand cmd = new NpgsqlCommand (commands, conn);
                    cmd.CommandTimeout = 300;
                    rowsaffect = await cmd.ExecuteNonQueryAsync ();
                    isSuccess = true;
                }
            } catch (Exception ex) {
                // NLog: catch any exception and log it.
                if (ex.InnerException != null) {
                    logger.Error (ex.InnerException, ex.InnerException.Message);
                    message = ex.InnerException.Message;
                } else {
                    logger.Error (ex, ex.Message);
                    message = ex.Message;
                }
            }

            var result = (isSuccess, rowsaffect, message);
            return await Task.FromResult (result);
        }

        public async Task < (bool, Object, string) > ExecuteCommandScalar (string commands) {
            var isSuccess = false;
            Object obj = null;
            var message = string.Empty;
            try {
                using (NpgsqlConnection conn = new NpgsqlConnection (_glDataConnectionString)) {
                    conn.Open ();
                    NpgsqlCommand cmd = new NpgsqlCommand (commands, conn);
                    cmd.CommandTimeout = 300;
                    obj = await cmd.ExecuteScalarAsync ();
                    isSuccess = true;
                }
            } catch (Exception ex) {
                // NLog: catch any exception and log it.
                if (ex.InnerException != null) {
                    logger.Error (ex.InnerException, ex.InnerException.Message);
                    message = string.Empty;
                } else {
                    logger.Error (ex, ex.Message);
                    message = string.Empty;
                }
            }

            var result = (isSuccess, obj, message);
            return await Task.FromResult (result);
        }
    }
}