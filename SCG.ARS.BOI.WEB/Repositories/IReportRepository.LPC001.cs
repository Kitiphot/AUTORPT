using SCG.ARS.BOI.WEB.Models;
using SCG.ARS.BOI.WEB.Models.Packaging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Repositories
{
    public partial interface IReportRepository
    {
        //RPTLPC001_ShipmentSummary
        #region Transportation
        List<RPTLPC001_ShipmentMonthlyStatusViewModel> RPTLPC001_ShipmentMonthlyStatus(TransportationCriteria input);
        List<RPTLPC001_ShipmentYearlyStatusViewModel> RPTLPC001_ShipmentYearlyStatus(TransportationCriteria input);
        List<RPTLPC001_ShipmentMonthlyStatusAgingViewModel> RPTLPC001_ShipmentMonthlyStatusAging(TransportationCriteria input);
        List<RPTLPC001_ShipmentMonthlyCarrierStatusViewModel> RPTLPC001_ShipmentMonthlyCarrierStatus(TransportationCriteria input);
        List<RPTLPC001_ShipmentDailyStatusViewModel> RPTLPC001_ShipmentDailyStatus(TransportationCriteria input);

        #endregion
    }
}
