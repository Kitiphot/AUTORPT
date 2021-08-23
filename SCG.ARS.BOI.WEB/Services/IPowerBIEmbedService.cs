using SCG.ARS.BOI.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.Mvc;

namespace SCG.ARS.BOI.WEB.Services
{
    interface IPowerBIEmbedService
    {
        PowerBIEmbedConfigModel EmbedConfig { get; }
        //TileEmbedConfig TileEmbedConfig { get; }

        Task<bool> EmbedReport(string userName, string roles);
        //Task<bool> EmbedDashboard();
        //Task<bool> EmbedTile();
    }
}
