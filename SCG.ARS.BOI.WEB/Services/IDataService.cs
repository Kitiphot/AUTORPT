namespace SCG.ARS.BOI.WEB.Services {
    using System.Collections.Generic;
    using System.Data;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using System;
    using Models;
    //using SCG.ARS.BOI.WEB.Models;
    //using SCG.ARS.BOI.WEB.GLData;

    public interface IDataService {
        Task < (bool, DataTable, string) > ExecuteCommandReader (string commands);
        Task < (bool, Int32, string) > ExecuteCommandNoneQuery (string commands);
        Task < (bool, Object, string) > ExecuteCommandScalar (string commands);
    }
}