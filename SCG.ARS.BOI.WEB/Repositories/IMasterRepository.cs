using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using SCG.ARS.BOI.WEB.Entities.MasterDb;
using SCG.ARS.BOI.WEB.Models.Master;
using SCG.ARS.BOI.WEB.ViewModels;

namespace SCG.ARS.BOI.WEB.Repositories
{
    public interface IMasterRepository
    {
        List<SourceSchema> GetSourceSchema();
        List<Schema> GetSchemas();
        Task<(bool, Schema, string)> SaveSchema(Schema request);
        Task<(bool, Schema, string)> DeleteSchema(Schema request);
        List<Table> GetTables(string scheme);
        List<Column> GetColumns(string schema, string table);
        List<Function> GetSourceFunctions(string schema);
        List<Parameter> GetFunctionParameters(string schema, string function_name);
        List<FunctionColumn> GetColumnParameters(string schema, string function_name);
        List<MasterFunction> GetFunctions(int? p_schema_id = null, int? p_report_id = null, int? p_function_id = null);
        Task<(bool, MasterFunction, string)> SaveFunction(MasterFunction request);
        Task<(bool, MasterFunction, string)> DeleteFunction(MasterFunction request);

        List<ReportGroup> GetReportGroups();
        List<ReportGroup> GetReportGroups(int? p_schema_id = null, int? p_group_id = null);
        Task<(bool, ReportGroup, string)> SaveGroup(ReportGroup request);
        Task<(bool, ReportGroup, string)> DeleteGroup(ReportGroup request);

        Task<(bool, ReportGroup, string)> SaveReport(ReportGroup request);
        Task<(bool, ReportGroup, string)> UpdateReportActive(ReportGroup request);
        Task<(bool, ReportGroup, string)> DeleteReportGroup(ReportGroup request);
        List<Report> GetReports();
        List<Report> GetReports(int? p_schema_id = null, int? p_report_id = null, int? p_group_id = null);
        List<Report> GetGroupReports(int? schema_id = null, int? group_id = null);
        Task<(bool, List<Report>, string)> AddReports(List<Report> request);
        Task<(bool, List<Report>, string)> DeleteReports(Report request);
        //List<Parameter> GetParameters(string schema, string function_name);
        List<ParameterType> GetParameterTypes();
        List<TemplateReportMapping> GetTemplateReportMapping(string schema_name = null, int? p_template_report_mapping_id = null, int? p_function_id = null, int? p_report_id = null, bool onlyActive = false);
        Task<(bool, TemplateReportMapping, string)> SaveTemplateReportMapping(TemplateReportMapping request);
        Task<(bool, TemplateReportMapping, string)> CopyTemplateReportMapping(TemplateReportMapping request);
        Task<(bool, string, string)> DownloadTemplateReportMapping(TemplateReportMapping request, int? limit = null);
        Task<(bool, string, string)> DownloadWithTemplateReportMapping(TemplateReportMapping request);
        Task<(bool, TemplateReportMapping, string)> UploadTemplateReportMapping(string uploadedPath, int template_report_mapping_id);
        Task<(bool, TemplateReportMapping, string)> DeleteTemplateReportMapping(TemplateReportMapping request);
        Task<(bool, TemplateReportMapping, string)> ResetTemplateReportMapping(TemplateReportMapping request);
        Task<(bool, TemplateReportMapping, string)> RemoveTemplate(TemplateReportMapping request);
        List<TemplateParameterMapping> GetTemplateParameterMapping(string p_schema_name = null, int? p_template_report_mapping_id = null, int? p_function_id = null, int? p_report_id = null, int? p_parameter_id = null);
        Task<(bool, string)> AddTemplateParameterMapping(TemplateReportMapping request);
        Task<(bool, List<TemplateParameterMapping>, string)> SaveTemplateParameterMapping(TemplateReportMapping header, List<TemplateParameterMapping> list);
        Task<(bool, TemplateParameterMapping, string)> RemoveTemplateParameterMapping(TemplateParameterMapping request);
        List<TemplateColumnMapping> GetTemplateColumnMapping(string p_schema_name = null, int? p_template_report_mapping_id = null, int? p_function_id = null, int? p_report_id = null, int? p_column_id = null);
        Task<(bool, string)> AddTemplateColumnMapping(TemplateReportMapping request);
        Task<(bool, List<TemplateColumnMapping>, string)> SaveTemplateColumnMapping(List<TemplateColumnMapping> list);
        Task<(bool, List<TemplateColumnMapping>, string)> SaveAddNewTemplateColumnMapping(List<TemplateColumnMapping> list);
        Task<(bool, TemplateTriggerPropertiesViewModel, string)> SaveTemplateTrigger(TemplateTriggerPropertiesViewModel item);
        Task<(bool, TemplateTriggerPropertiesViewModel, string)> DeleteTemplateTrigger(TemplateTriggerPropertiesViewModel item);
        Task<(bool, TemplateColumnMapping[], string)> DeleteTemplateColumnMapping(TemplateColumnMapping[] request);
        Task<(bool, List<TemplateColumnMapping>, string)> GetColumnSelection(TemplateReportMapping report, List<TemplateColumnMapping> selectedColumns);
        Task<(bool, DataTable, string)> GetFunctionData(string query, List<TemplateParameterMapping> parameters, CommandType commandType = CommandType.StoredProcedure);
        List<EmailScheduler> GetEmailScheduler(int? p_email_scheduler_id);
        List<TemplateTrigger> GetTemplateTrigger(int? template_trigger_id = null, string sched_name = null, string trigger_name = null,
            string trigger_group = null, string template_subject = null, string trigger_email = null, string trigger_state = null);
        Task<(bool, EmailScheduler, string)> SaveEmailScheduler(EmailScheduler item);
        List<EmailAttachment> GetEmailAttachment(int? p_email_scheduler_id);
        bool SaveEmailAttachment(int id, int[] ids);

        Task<(bool, string)> saveUpload(List<StockMaster> list);
        Task<(bool, string)> DeleteStock(int? StockID);
        List<Menu> GetMasterMenu();
        List<Menu> GetSubMenu(int parent_id);
        List<Menu> GetPageMenu(int parent_id);

        Task<(bool, string)> UpdateMasterSchema();
        Task<(bool, string)> UpdateMasterTables();
        Task<(bool, string)> UpdateMasterColumns();

        //List<string> GetCustomers();

        Task<(bool, List<TreeView>, string)> GetTreeView();
        //Task<(bool, List<ReportsCustomizationDetailModel>, string)> GetReportsCustomization();
        //List<ReportsCustomizationItemModel> GetReportsCustomization();
        Task<(bool, StockMaster, string)> SaveStock(StockMaster request);
        List<Customer> GetCustomers(string pwarehouse);
        List<StorageType> GetStorageType(string pwarehouse);
        List<DCType> GetDCType();
        List<StockMaster> GetStock();
        List<StockMaster> GetStockMaster();


        PowerBIEmbeddedViewModel GetPowerBI(string reportId);
        }
}