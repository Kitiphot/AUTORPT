using System.Collections.Generic;
using SCG.ARS.BOI.WEB.Models.Master;
using SCG.ARS.BOI.WEB.ViewModels;

namespace SCG.ARS.BOI.WEB.Repositories
{
    public interface IFunctionTemplateRepository
    {
         List<ColumnTemplate> GetColumnTemplate();
         List<CustomerTemplate> GetCustomerTemplate();
         List<EmailReportMappingViewModel> GetEmailReportMapping();
         List<EmailAddress> GetEmailAddresses();
    }
}