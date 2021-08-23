using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using SCG.ARS.BOI.WEB.Models;
using SCG.ARS.BOI.WEB.Models.ILB;

namespace SCG.ARS.BOI.WEB.Repositories
{
    public partial interface IReportRepository
    {
        List<RPTILB_Summary_Status> ILB001_Summary_Status(ILBRequestModel input);
        List<RPTILB_Summary_Chart> ILB001_Summary_Chart(ILBRequestModel input);
        
        List<RPTILB001ViewModel> RPTILB001_Report(ILBRequestModel request);
        List<RPTILB002ViewModel> RPTILB002_Report(ILBRequestModel request);
        List<RPTILB_Summary_Shpmnt_Chart> ILB002_Summary_Shpmnt_Chart(ILBRequestModel input);
        List<RPTILB_Summary_Shpmnt_Status> ILB002_Summary_Status(ILBRequestModel input);
        List<RPTILB003ViewModel> RPTILB003_Report(ILBRequestModel request);
        List<RPTILB_Po_Kpi_monthly_Status> ILB003_Summary_PO_Monthly_Status(ILBRequestModel input);
        List<RPTILB_Po_Kpi_Status> ILB003_Summary_Status(ILBRequestModel input);

        List<RPTILB004ViewModel> RPTILB004_Report(ILBRequestModel request);
        List<RPTILB_monthy_shpmnt_kpi> ILB004_Summary_Chart(ILBRequestModel input);
        List<RPTILB_Summary_shpmnt_kpi_Status> ILB004_Summary_Status(ILBRequestModel input);

        DataTable RPTILB005_Report(ILBRequestModel request, string dateType);
        List<ILBContainerTypeViewModel> RPTILB_GetContainerType();
        List<RPTILB_export_monthy_carrier> ILB005_CYDate_Chart(ILBRequestModel input);
		List<RPTILB_export_monthy_carrier> ILB005_ReturnDate_Chart(ILBRequestModel input);
		List<RPTILB_export_summary_carrier> ILB005_Summary_Status(ILBRequestModel input);

        List<RPTILB006ViewModel> RPTILB006_Report(ILBRequestModel request);
        List<RPTILB_Haulage_Chart> ILB006_Summary_Chart(ILBRequestModel input);
        List<RPTILB_Summary_Haulage> ILB006_Summary_Status(ILBRequestModel input);

        List<RPTILB007ViewModel> RPTILB007_Report(ILBRequestModel request);
        List<RPTILB07_Summary_Shpmnt_Chart> ILB007_Summary_Chart(ILBRequestModel input);
        List<RPTILB07_Summary_Shpmnt_Status> ILB007_Summary_Status(ILBRequestModel input);

		DataTable RPTILB008_Report(ILBRequestModel request, string dateType);
		List<RPTILB_export_monthy_carrier> ILB008_CYDate_Chart(ILBRequestModel input);
		List<RPTILB_export_monthy_carrier> ILB008_ReturnDate_Chart(ILBRequestModel input);
		List<RPTILB_export_summary_carrier> ILB008_Summary_Status(ILBRequestModel input);


		DataTable RPTILB009_Report(ILBRequestModel request, string dateType);


        List<RPTILB_Export_Summary_Order_Status> ILB010_Summary_Status(ILBRequestModel input);
        DataTable RPTILB010_Report(ILBRequestModel request, string dateType);

        Task<(bool, List<MiscDataSelectionModel>)> RPTILB_GetService();
        Task<(bool, List<MiscDataSelectionModel>)> RPTILB_GetWarehouseType();
        

    }
}
