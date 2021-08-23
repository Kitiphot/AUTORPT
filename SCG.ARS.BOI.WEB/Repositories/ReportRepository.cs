using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2.FlowControl;
using Microsoft.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using NLog;
using Npgsql;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
//using Remotion.Linq.Clauses;
using SCG.ARS.BOI.WEB.Configuration;
using SCG.ARS.BOI.WEB.Models;
using SCG.ARS.BOI.WEB.Models.Packaging;

namespace SCG.ARS.BOI.WEB.Repositories
{
    public partial class ReportRepository : IReportRepository// RestRepositoryBase,IReportRepository
    {
        static Logger logger = LogManager.GetCurrentClassLogger();
        private string connectionString;
        private string connectionStringPKG;
        private ConnectionStrings _connections;
        public ReportRepository(IConfiguration configuration,
            IOptions<ConnectionStrings> connections)
        {
            _connections = connections.Value;
            connectionString = _connections.PDLakeConnection;
            connectionStringPKG = _connections.PKGConnection;
        }
        internal IDbConnection Connection
        {
            get
            {
                return new NpgsqlConnection(connectionString);
            }
        }

        internal NpgsqlConnection _Connection
        {
            get
            {
                return new NpgsqlConnection(connectionString);
            }
        }

        internal IDbConnection ConnectionPKG
        {
            get
            {
                return new NpgsqlConnection(connectionStringPKG);
            }
        }

        internal NpgsqlConnection _ConnectionPKG
        {
            get
            {
                return new NpgsqlConnection(connectionStringPKG);
            }
        }

        public DataTable GetReport01(DateTime? start_date, DateTime? end_date, List<int> dc_list, List<int> customers_list)
        {
            var dateFormat = "yyyy-MM-dd";
            var starDate = start_date.HasValue ? $"'{start_date.Value.ToString(dateFormat)}'" : "null";
            var endDate = end_date.HasValue ? $"'{end_date.Value.ToString(dateFormat)}'" : "null";
            var dcList = (dc_list != null && dc_list.Count > 0) ? $"'{{{string.Join(",", dc_list.ToArray())}}}'" : "null";
            var customerList = (customers_list != null && customers_list.Count > 0) ? $"'{{{string.Join(",", customers_list.ToArray())}}}'" : "null";

            DataTable dataTable = new DataTable();
            try
            {
                using (NpgsqlConnection connection = _Connection)
                {
                    connection.Open();
                    string query = $"Select * From wh.getreport01({starDate}, {endDate}, {dcList}, {customerList})";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
            }

            return dataTable;
        }

        public List<RPTCDC001ReceivingViewModel> RPTCDC001_RecivingReport(WarehouseCDCRequestDateModel input)
        {
            //input.selectDc = input.selectDc == null ? new List<int> { } : input.selectDc;
            //input.selectCustomer = input.selectCustomer == null ? new List<int> { } : input.selectCustomer;
            string[] dc = input.selectDc?.ToArray() ?? new string[] { };
            string[] customer = input.selectCustomer?.ToArray() ?? new string[] { };
            DateTime dateFrom = DateTime.Parse(input.selectStartDate);
            DateTime dateTo = DateTime.Parse(input.selectEndDate);
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTCDC001ReceivingViewModel>($@"select receiveddate
                    ,statusid              
                    ,statusname            
                    ,po_no
                    ,invoice_no
                    ,rc                    
                    ,ean                   
                    ,suppliercode          
                    ,suppliername          
                    ,sku                   
                    ,productbarcode        
                    ,productcode           
                    ,productdescription    
                    ,weight             
                    ,volume                
                    ,qty_in_ewm            
                    ,unit_code             
                    ,uom                   
                    ,productgroupcode      
                    ,productgroupname      
                    ,doctype               
                    ,docrefno              
                    ,inbound               
                    ,entiled               
                    ,chargeunit            
                    ,chargeitem     
                    ,customer_name
                    ,arrival_date
					,transit_date
                    from wh.getreport01_trans(@dateFrom,@dateTo,@dc,@customer,@selectCustomerName,@selectStatus,@selectTime,@selectDateType)"
                        , param: new
                        {
                            dateFrom,
                            dateTo,
                            dc,
                            customer,
                            input.selectCustomerName,
                            input.selectStatus,
                            input.selectTime,
                            input.selectDateType
                        }, commandTimeout: 3000);



                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        public List<RPTCDC001ReceivingChartViewModel> RPTCDC001_RecivingReportChart(DateTime selectStartDate, DateTime selectEndDate, List<int> selectCustomer)
        {
            selectCustomer = selectCustomer == null ? new List<int> { } : selectCustomer;
            List<int> selectDc = new List<int> { };
            selectStartDate.ToString("yyyy-MM-dd");
            selectEndDate.ToString("yyyy-MM-dd");
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    //<<<<<<< HEAD
                    // var data = dbConnection.Query<RPTCDC001ReceivingChartViewModel> ("select cast(receiveddate as date) as receiveddate" +
                    //     ", sum(qty_in_ewm) as qty_in_ewm  " +
                    //     "from wh.getreport01('{" + selectCustomer + "}','" + selectStartDate + "','" + selectEndDate + "')" +
                    //     "group by cast(receiveddate as date) order by cast(receiveddate as date)");
                    // return data.ToList ();
                    //=======   
                    //selectCustomer = selectCustomer == null ? new List<int> { } : selectCustomer;
                    var data = dbConnection.Query<RPTCDC001ReceivingChartViewModel>($@"
                    select cast(receiveddate as date) as receiveddate , sum(qty_in_ewm) as qty_in_ewm 
                    from wh.getreport01('{selectStartDate}','{selectEndDate}','{{{string.Join(",", (selectDc).ToArray())}}}','{{{string.Join(",", (selectCustomer).ToArray())}}}') 
                    group by cast(receiveddate as date) order by cast(receiveddate as date)");
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        public DataTable GetReport03(DateTime? start_date, DateTime? end_date, List<int> dc_list, List<int> customers_list)
        {
            // using (IDbConnection dbConnection = Connection) {
            //     dbConnection.Open ();
            //     var data = dbConnection.Query<dynamic> ($"Select * From wh.getreport03({customer_id})");
            //     var result = Helpers.Helper.ToDataTable (data);
            //     return result;
            // }

            var dateFormat = "yyyy-MM-dd";
            var starDate = start_date.HasValue ? $"'{start_date.Value.ToString(dateFormat)}'" : "null";
            var endDate = end_date.HasValue ? $"'{end_date.Value.ToString(dateFormat)}'" : "null";
            var dcList = (dc_list != null || dc_list.Count > 0) ? $"'{{{string.Join(",", dc_list.ToArray())}}}'" : "null";
            var customerList = (customers_list != null || customers_list.Count > 0) ? $"'{{{string.Join(",", customers_list.ToArray())}}}'" : "null";

            DataTable dataTable = new DataTable();
            try
            {
                using (NpgsqlConnection connection = _Connection)
                {
                    connection.Open();
                    string query = $"Select * From wh.getreport03({starDate}, {endDate}, {dcList}, {customerList})";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }

            return dataTable;
        }

        public List<RPT001GRGIReportViewModel> RPT001_GRGIReports()
        {
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPT001GRGIReportViewModel>("select * from wh.get_grgi_bycustomer('2020-06-01','2020-06-02',10)", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }
        public List<RPTCDC002StockOnHandViewModel> RPTCDC002_StockOnHandReport(WarehouseRequestStockModel input)
        {
            string[] dc = input.selectDc?.ToArray() ?? new string[] { };
            string[] customer = input.selectCustomer?.ToArray() ?? new string[] { };
            string[] productgroup = input.selectProductGroup?.ToArray() ?? new string[] { };
            DateTime date = DateTime.Parse(input.selectDate);
            try
            {

                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTCDC002StockOnHandViewModel>($@"select 
                    stock_date
                    , lv
                    , storage_type
                    , location_code
                    , handling_unit
                    , sku
                    , sku_desc
                    , status
                    , ean
                    , qty
                    , uom
                    , sticker_uid
                    , entifled
                    , unit_volumn
                    , m3
                    , weight_uom
                    , weight_kg
                    , cb
                    , vlength
                    , vheight
                    , gr_date
                    , aging
                    , material_group
                    , product_group
                    , age_range
                    , level
                    , expire_date
                    , mfg_date
                    , check_location_type
                    , charge_per_location
                    , 'check'
                    , po_no
                    , invoice_no
                    from wh.getreport02_trans(@date,@dc,@customer,@selectCustomerName,@selectLocationtype,@selectAging,@productgroup)"
                        , param: new
                        {
                            date,
                            dc,
                            customer,
                            input.selectCustomerName,
                            input.selectLocationtype,
                            input.selectAging,
                            productgroup
                        }, commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }
        public List<RPTESC003StockOnHandViewModel> RPTESC003_StockOnHandReport(WarehouseESCRequestStockModel input)
        {
            int[] dc = input.selectDc?.ToArray() ?? new int[] { };
            int[] customer = input.selectCustomer?.ToArray() ?? new int[] { };
            DateTime date = DateTime.Parse(input.selectDate);
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTESC003StockOnHandViewModel>($@"select 
                    stock_date
                    , lv
                    , storage_type
                    , location_code
                    , handling_unit
                    , sku
                    , sku_desc
                    , status
                    , ean
                    , qty
                    , uom
                    , sticker_uid
                    , entifled
                    , unit_volumn
                    , m3
                    , weight_uom
                    , weight_kg
                    , cb
                    , vlength
                    , vheight
                    , gr_date
                    , aging
                    , material_group
                    , product_group
                    , age_range
                    , level
                    , expire_date
                    , mfg_date
                    , check_location_type
                    , charge_per_location
                    , 'check'
                    , po_no
                    , invoice_no
                    from wh.getreport02_esc_trans(@date::date,@dc,@customer,@selectCustomerName,@selectLocationtype,@selectAging)"
                        , param: new
                        {
                            date,
                            dc,
                            customer,
                            input.selectCustomerName,
                            input.selectLocationtype,
                            input.selectAging
                        }, commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }
        public List<RPTCDC002StockByLocationTypeViewModel> RPTCDC002_StockByLocationType(WarehouseRequestStockModel input)
        {
            string[] dc = input.selectDc?.ToArray() ?? new string[] { };
            string[] customer = input.selectCustomer?.ToArray() ?? new string[] { };
            string[] productgroup = input.selectProductGroup?.ToArray() ?? new string[] { };
            DateTime date = DateTime.Parse(input.selectDate);

            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTCDC002StockByLocationTypeViewModel>($@"select 
                    	location_type
	                    ,total_location
	                    ,plan_location
	                    ,used_location
                    from wh.getreport02_stock_bylocationtype(@date::date,@dc,@customer,@productgroup)"
                        , param: new
                        {
                            date,
                            dc,
                            customer,
                            productgroup
                        }
                        , commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }
        public List<RPTESC003StockByLocationTypeViewModel> RPTESC003_StockByLocationType(WarehouseESCRequestStockModel input)
        {
            input.selectDc = input.selectDc == null ? new List<int> { } : input.selectDc;
            input.selectCustomer = input.selectCustomer == null ? new List<int> { } : input.selectCustomer;
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTESC003StockByLocationTypeViewModel>($@"select 
                    	location_type
	                    ,total_location
	                    ,plan_location
	                    ,used_location
                    from wh.getreport02_esc_stock_bylocationtype('{input.selectDate}','{{{string.Join(",", input.selectDc.ToArray())}}}','{{{string.Join(",", input.selectCustomer.ToArray())}}}')", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }


        public List<RPTCDC002StorageByCustomerLocationViewModel> RPTCDC002_StorageByCustomerLocation(WarehouseRequestStockModel input)
        {
            string[] dc = input.selectDc?.ToArray() ?? new string[] { };
            string[] customer = input.selectCustomer?.ToArray() ?? new string[] { };
            string[] productgroup = input.selectProductGroup?.ToArray() ?? new string[] { };
            DateTime date = DateTime.Parse(input.selectDate);
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTCDC002StorageByCustomerLocationViewModel>($@"select 
                    	location_type
	                    ,customer_name
	                    ,used_location
                    from wh.getreport02_stock_bycustomer_location(@date::date,@dc,@customer,@productgroup)",
                    param: new
                    {
                        date,
                        dc,
                        customer,
                        productgroup
                    }
                    , commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }
        public List<RPTESC003StorageByCustomerLocationViewModel> RPTESC003_StorageByCustomerLocation(WarehouseESCRequestStockModel input)
        {
            input.selectDc = input.selectDc == null ? new List<int> { } : input.selectDc;
            input.selectCustomer = input.selectCustomer == null ? new List<int> { } : input.selectCustomer;
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTESC003StorageByCustomerLocationViewModel>($@"select 
                    	location_type
	                    ,customer_name
	                    ,used_location
                    from wh.getreport02_esc_stock_bycustomer_location('{input.selectDate}','{{{string.Join(",", input.selectDc.ToArray())}}}','{{{string.Join(",", input.selectCustomer.ToArray())}}}')", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        public List<RPTCDC002StorageByCustomerLocationPieceViewModel> RPTCDC002_StorageByCustomerLocationPiece(WarehouseRequestStockModel input)
        {
            string[] dc = input.selectDc?.ToArray() ?? new string[] { };
            string[] customer = input.selectCustomer?.ToArray() ?? new string[] { };
            string[] productgroup = input.selectProductGroup?.ToArray() ?? new string[] { };
            DateTime date = DateTime.Parse(input.selectDate);
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTCDC002StorageByCustomerLocationPieceViewModel>($@"select 
                    	location_type
	                    ,customer_name
	                    ,qty
                    from wh.getreport02_stock_bycustomer_piece(@date::date,@dc,@customer,@productgroup)"
                    , param: new
                    {
                        date,
                        dc,
                        customer,
                        productgroup
                    }, commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }
        public List<RPTESC003StorageByCustomerLocationPieceViewModel> RPTESC003_StorageByCustomerLocationPiece(WarehouseESCRequestStockModel input)
        {
            input.selectDc = input.selectDc == null ? new List<int> { } : input.selectDc;
            input.selectCustomer = input.selectCustomer == null ? new List<int> { } : input.selectCustomer;
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTESC003StorageByCustomerLocationPieceViewModel>($@"select 
                    	location_type
	                    ,customer_name
	                    ,qty
                    from wh.getreport02_esc_stock_bycustomer_piece('{input.selectDate}','{{{string.Join(",", input.selectDc.ToArray())}}}','{{{string.Join(",", input.selectCustomer.ToArray())}}}')", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }


        public List<RPTCDC002StockByAgingViewModel> RPTCDC002_StockByAging(WarehouseRequestStockModel input)
        {
            string[] dc = input.selectDc?.ToArray() ?? new string[] { };
            string[] customer = input.selectCustomer?.ToArray() ?? new string[] { };
            string[] productgroup = input.selectProductGroup?.ToArray() ?? new string[] { };
            DateTime date = DateTime.Parse(input.selectDate);
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTCDC002StockByAgingViewModel>($@"select 
                    	customer_name,
		                total_product,
		                age1,
		                age2,
		                age3,
		                age4,
		                age5,
		                age6
                    from wh.getreport02_stock_byaging(@date::date,@dc,@customer,@productgroup)"
                    , param: new
                    {
                        date,
                        dc,
                        customer,
                        productgroup
                    }
                    , commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }
        public List<RPTESC003StockByAgingViewModel> RPTESC003_StockByAging(WarehouseESCRequestStockModel input)
        {
            input.selectDc = input.selectDc == null ? new List<int> { } : input.selectDc;
            input.selectCustomer = input.selectCustomer == null ? new List<int> { } : input.selectCustomer;
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTESC003StockByAgingViewModel>($@"select 
                    	customer_name,
		                total_product,
		                age1,
		                age2,
		                age3,
		                age4,
		                age5,
		                age6
                    from wh.getreport02_esc_stock_byaging('{input.selectDate}','{{{string.Join(",", input.selectDc.ToArray())}}}','{{{string.Join(",", input.selectCustomer.ToArray())}}}')", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }


        public List<RPT002PROSTAReportViewModel> RPT002_PROSTAReports()
        {
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPT002PROSTAReportViewModel>("select * from wh.get_product_status_bycustomer(1024,'2020-07-10','2020-07-10')", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        public List<RPTCDC003DispatchingViewModel> RPTCDC003_DispatchingReport(WarehouseCDCRequestDateModel input)
        {

            string[] dc = input.selectDc?.ToArray() ?? new string[] { };
            string[] customer = input.selectCustomer?.ToArray() ?? new string[] { };
            DateTime dateFrom = DateTime.Parse(input.selectStartDate);
            DateTime dateTo = DateTime.Parse(input.selectEndDate);
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTCDC003DispatchingViewModel>($@"select 
                    create_date,
                    statusid, 
                    statusname, 
                    po_invoice, 
                    so_number, 
                    dn, 
                    customercode, 
                    customername, 
                    doctype, 
                    docrefno, 
                    inbound, 
                    ean, 
                    sku, 
                    productbarcode, 
                    productcode, 
                    productdescription, 
                    suppliercode, 
                    suppliername, 
                    weight, 
                    volume, 
                    qty_in_ewm, 
                    unit_code, 
                    uom, 
                    productgroupcode, 
                    productgroupname, 
                    picking_instruction_date,
                    stock_hold_date, 
                    picking_date, 
                    shippingdate, 
                    shipmentnogroup, 
                    finaldestinationcode, 
                    finaldestinationlongname, 
                    deliverydate, 
                    entiled 
                    from wh.getreport03_trans(@dateFrom,@dateTo,@dc,@customer,@selectCustomerName,@selectStatus,@selectTime,@selectDateType)"
                    , param: new
                    {
                        dateFrom,
                        dateTo,
                        dc,
                        customer,
                        input.selectCustomerName,
                        input.selectStatus,
                        input.selectTime,
                        input.selectDateType
                    }, commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        public List<RPTESC002DispatchingViewModel> RPTESC002_DispatchingReport(WarehouseESCRequestDateModel input)
        {
            int[] dc = input.selectDc?.ToArray() ?? new int[] { };
            int[] customer = input.selectCustomer?.ToArray() ?? new int[] { };
            DateTime dateFrom = DateTime.Parse(input.selectStartDate);
            DateTime dateTo = DateTime.Parse(input.selectEndDate);
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTESC002DispatchingViewModel>($@"select 
                    pickingdate,
                    statusname, 
                    po_invoice, 
                    dn, 
                    customername, 
                    sku, 
                    productdescription, 
                    weight, 
                    qty_in_ewm, 
                    uom, 
                    productgroupname, 
                    sonumber, 
                    shippingdate, 
                    shipmentnogroup, 
                    finaldestinationlongname, 
                    deliverydate, 
                    entiled ,
                    license_plate,
                    batch_no,
                    lot_no,
                    receive_package_name,
                    actual_weight
                    from wh.getreport03_esc_trans(@dateFrom,@dateTo,@dc,@customer,@selectCustomerName,@selectStatus,@selectTime,@selectDateType)"
                    , param: new
                    {
                        dateFrom,
                        dateTo,
                        dc,
                        customer,
                        input.selectCustomerName,
                        input.selectStatus,
                        input.selectTime,
                        input.selectDateType
                    }, commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        public List<RPTCDC004InventoryInquiryViewModel> RPTCDC004_InventoryInquiryReport(DateTime selectStartDate, DateTime selectEndDate, List<int> selectCustomer)
        {
            selectCustomer = selectCustomer == null ? new List<int> { } : selectCustomer;
            selectStartDate.ToString("yyyy-MM-dd");
            selectEndDate.ToString("yyyy-MM-dd");
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTCDC004InventoryInquiryViewModel>($@"select warehouse,  
                    location,  
                    pallet_no,  
                    tag_no,  
                    product_code,  
                    product_name,  
                    product_condition,  
                    inventory_qty,  
                    balance_qty,  
                    unit_code,  
                    bin_block,  
                    product_group,  
                    serial,  
                    lot_no,  
                    weight,  
                    volumn,  
                    received_date,  
                    expired_date,  
                    mfg_date,  
                    last_movement,  
                    po_no,  
                    invoice_no,  
                    doc_type  
                    from wh.getreport04('{{{string.Join(",", selectCustomer.ToArray())}}}', '{selectStartDate}', '{selectEndDate}')", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        public DataTable GetReceiving(int customer_id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetStockOnHand(int customer_id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetDispatching(int customer_id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetInventoryInquiry(int customer_id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetPickPack(int customer_id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetCheckMove(int customer_id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetPalletControlDaily()
        {
            throw new NotImplementedException();
        }

        public DataTable GetNotShipment()
        {
            throw new NotImplementedException();
        }

        public DataTable GetNotGI()
        {
            throw new NotImplementedException();
        }

        public DataTable GetWaitingList()
        {
            throw new NotImplementedException();
        }

        public DataTable GetOrderCommit()
        {
            throw new NotImplementedException();
        }

        public DataTable GetDocumentReturn()
        {
            throw new NotImplementedException();
        }

        public DataTable GetOntime()
        {
            throw new NotImplementedException();
        }

        public DataTable GetReject()
        {
            throw new NotImplementedException();
        }

        public DataTable GetTruckUtilization()
        {
            throw new NotImplementedException();
        }

        public DataTable GetTranshare()
        {
            throw new NotImplementedException();
        }

        public async Task<(bool, List<MiscDataSelectionModel>)> RPTWH_GetCustomer(string warehouse, List<string> dc)
        {
            dc = dc == null ? new List<string> { } : dc;
            var isSuccess = false;
            var data = new List<MiscDataSelectionModel>();
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var datatmp = dbConnection.Query<MiscDataSelectionModel>($@"select 
                            customer_code as DataValue_Key
                            , customer_code||':'||customer_name as DataDisplay 
                            from wh.get_common_customer('{warehouse}',null,'{{{string.Join(", ", dc.ToArray())}}}')");
                    data = datatmp.ToList();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                // NLog: catch any exception and log it.
                if (ex.InnerException != null)
                {
                    logger.Error(ex.InnerException, $"Exception on GetCustomer");
                }
                else
                {
                    logger.Error(ex, $"Exception on GetCustomer");
                }
            }

            var result = (isSuccess, data);
            return await Task.FromResult(result);
        }

        public async Task<(bool, List<MiscDataSelectionModel>)> RPTWH_GetProductGroup(string warehouse)
        {

            var isSuccess = false;
            var data = new List<MiscDataSelectionModel>();
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var datatmp = dbConnection.Query<MiscDataSelectionModel>($@"select 
                            product_group_code as DataValue_Key
                            , CASE WHEN ((product_group_name = '') IS NOT FALSE) THEN product_group_code ELSE (product_group_code ||  ':' || product_group_name) END DataDisplay
                            from wh.get_common_product_group('{warehouse}')");
                    data = datatmp.ToList();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                // NLog: catch any exception and log it.
                if (ex.InnerException != null)
                {
                    logger.Error(ex.InnerException, $"Exception on GetCustomer");
                }
                else
                {
                    logger.Error(ex, $"Exception on GetCustomer");
                }
            }

            var result = (isSuccess, data);
            return await Task.FromResult(result);
        }

        public async Task<(bool, List<MiscDataSelectionModel>)> RPTWHESC_GetCustomer(string warehouse, List<int> dc)
        {
            //dc = dc == null ? new List<int> { } : dc;
            int[] location = dc?.ToArray() ?? new int[] { };
            var isSuccess = false;
            var data = new List<MiscDataSelectionModel>();
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var datatmp = dbConnection.Query<MiscDataSelectionModel>($@"select 
                            customer_id as DataValue_Key
                            , customer_name as DataDisplay 
                            from wh.get_common_customer(@warehouse,@location)"
                            , param: new
                            {
                                warehouse,
                                location
                            }, commandTimeout: 3000);
                    data = datatmp.ToList();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                // NLog: catch any exception and log it.
                if (ex.InnerException != null)
                {
                    logger.Error(ex.InnerException, $"Exception on GetCustomer");
                }
                else
                {
                    logger.Error(ex, $"Exception on GetCustomer");
                }
            }

            var result = (isSuccess, data);
            return await Task.FromResult(result);
        }

        public List<RPTESC001ReceivingViewModel> RPTESC001_RecivingReport(WarehouseESCRequestDateModel input)
        {
            int[] dc = input.selectDc?.ToArray() ?? new int[] { };
            int[] customer = input.selectCustomer?.ToArray() ?? new int[] { };
            DateTime dateFrom = DateTime.Parse(input.selectStartDate);
            DateTime dateTo = DateTime.Parse(input.selectEndDate);
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTESC001ReceivingViewModel>($@"select receiveddate
                    ,statusid              
                    ,statusname            
                    ,po_invoice            
                    ,rc                    
                    ,ean                   
                    ,suppliercode          
                    ,suppliername          
                    ,sku                   
                    ,productbarcode        
                    ,productcode           
                    ,productdescription    
                    ,weight             
                    ,volume                
                    ,qty_in_ewm            
                    ,unit_code             
                    ,uom                   
                    ,productgroupcode      
                    ,productgroupname      
                    ,doctype               
                    ,docrefno              
                    ,inbound               
                    ,entiled               
                    ,chargeunit            
                    ,chargeitem     
                    ,customer_name
                    ,arrival_date
                    ,license_plate
                    ,batch_no
                    ,lot_no
                    ,receive_package_name
                    ,actual_weight
                    from wh.getreport01_esc_trans(@dateFrom,@dateTo,@dc,@customer,@selectCustomerName,@selectStatus,@selectTime,@selectDateType)"
                        , param: new
                        {
                            dateFrom,
                            dateTo,
                            dc,
                            customer,
                            input.selectCustomerName,
                            input.selectStatus,
                            input.selectTime,
                            input.selectDateType
                        }, commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        public List<RPTLPC001ViewModel> RPTLPC001_Report(TransportationCriteria input)
        {
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();

                    var data = dbConnection.Query<RPTLPC001ViewModel>($@"select load_id
                    ,carrier_code
                    ,carrier_name
                    ,driver_name
                    ,truck_license
                    ,equipment_type
                    ,total_distance
                    ,total_volume
                    ,total_weight
                    ,total_shipments
                    ,total_stops
                    ,user_create_date
                    ,load_prtb_ctnt
                    ,delivery_number
                    ,order_number
                    ,orderdate
                    ,po_number
                    ,load_leg
                    ,customer_code
                    ,customer_name
                    ,origin_code
                    ,origin_name
                    ,origin_address
                    ,origin_region
                    ,origin_country
                    ,origin_postal_code
                    ,destination_code
                    ,destination_name
                    ,destination_address
                    ,destination_region
                    ,destination_country
                    ,destination_postal_code
                    ,commodity_code
                    ,mat_freight_grp
                    ,shipment_prtb_ctnt
                    ,shipment_weight
                    ,pickup_code
                    ,pickup_name
                    ,pickup_block
                    ,pickup_street
                    ,pickup_city
                    ,pickup_region
                    ,pickup_country
                    ,pickup_postal_code
                    ,drop_code
                    ,drop_name
                    ,drop_block
                    ,drop_street
                    ,drop_city
                    ,drop_region
                    ,drop_country
                    ,drop_postal_code
                    ,request_delivery_date
                    ,incoterm
                    ,status_display
                    ,actual_tender_accept
                    ,actual_in_origin
                    ,actual_gi_date
                    ,actual_in_transit
                    ,actual_out_origin
                    ,actual_in_destination
                    ,actual_delivery_date
                    ,actual_out_destination
                    ,item_number
                    ,item_desc
                    ,item_quantity
                    ,item_weight
                    ,plannername         
                    ,origin_amphur       
                    ,origin_province       
                    ,destination_amphur         
                    ,destination_province         
                    ,pickup_amphur         
                    ,pickup_province         
                    ,drop_amphur         
                    ,drop_province         
                    from dom.getreport01_trans(@business,@customer,@fleet,@shippingPoint,@shipToRegion,@matGroup,@orderType,
                    @truckType,@plannerName,@orderStartDate::date,@orderEndDate::date,@status,@carrier,@aging_lpc)",
                    param: new
                    {
                        input.business,
                        input.customer,
                        input.fleet,
                        input.shippingPoint,
                        input.shipToRegion,
                        input.matGroup,
                        input.orderType,
                        input.truckType,
                        input.plannerName,
                        input.orderStartDate,
                        input.orderEndDate,
                        input.status,
                        input.carrier,
                        input.aging_lpc
                    }, commandTimeout: 3000);
                    //Warut S.
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        public async Task<(bool, List<MiscDataSelectionModel>)> RPTLPC_GetBusiness(TransportationRequestCommonModel input)
        {
            input.selectShippingpoint = input.selectShippingpoint == null ? new List<string> { } : input.selectShippingpoint;
            input.selectBusiness = input.selectBusiness == null ? new List<string> { } : input.selectBusiness;
            input.selectFleet = input.selectFleet == null ? new List<int> { } : input.selectFleet;
            input.selectMatfreight = input.selectMatfreight == null ? new List<string> { } : input.selectMatfreight;
            input.selectRegion = input.selectRegion == null ? new List<string> { } : input.selectRegion;
            var isSuccess = false;
            var data = new List<MiscDataSelectionModel>();
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var datatmp = dbConnection.Query<MiscDataSelectionModel>($@"select business_group as DataValue_Key, 
						business_group as DataDisplay 
						from dom.get_common_business_group(@selectBusiness,@selectMatfreight,@selectFleet,@selectShippingpoint,@selectRegion)",
                        param: new
                        {
                            input.selectBusiness,
                            input.selectMatfreight,
                            input.selectFleet,
                            input.selectShippingpoint,
                            input.selectRegion
                        });
                    data = datatmp.ToList();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                // NLog: catch any exception and log it.
                if (ex.InnerException != null)
                {
                    logger.Error(ex.InnerException, $"Exception on GetBusiness");
                }
                else
                {
                    logger.Error(ex, $"Exception on GetBusiness");
                }
            }

            var result = (isSuccess, data);
            return await Task.FromResult(result);
        }

        public async Task<(bool, List<MiscDataSelectionModel>)> RPTLPC_GetCustomer(string[] customerCode ,string customer)
        {
            var isSuccess = false;
            var data = new List<MiscDataSelectionModel>();
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var datatmp = dbConnection.Query<MiscDataSelectionModel>("select customer_code as DataValue_Key, customer_code || ' : ' || customer_name as DataDisplay from dom.get_common_customer(@customerCode,@customer)",
                        param:new
                        {
                            customerCode,
                            customer
                        });
                    data = datatmp.ToList();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                // NLog: catch any exception and log it.
                if (ex.InnerException != null)
                {
                    logger.Error(ex.InnerException, $"Exception on GetBusiness");
                }
                else
                {
                    logger.Error(ex, $"Exception on GetBusiness");
                }
            }

            var result = (isSuccess, data);
            return await Task.FromResult(result);
        }

        public async Task<(bool, List<MiscDataSelectionModel>)> RPTLPC_GetCustomerTest(string customer,string term)
        {
            var isSuccess = false;
            var data = new List<MiscDataSelectionModel>();
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var datatmp = dbConnection.Query<MiscDataSelectionModel>("select customer_code as DataValue_Key, customer_code || ' : ' || customer_name as DataDisplay from dom.get_common_customer(null,@term)",
                        param:new
                        {
                            term
                        });
                    data = datatmp.ToList();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                // NLog: catch any exception and log it.
                if (ex.InnerException != null)
                {
                    logger.Error(ex.InnerException, $"Exception on GetBusiness");
                }
                else
                {
                    logger.Error(ex, $"Exception on GetBusiness");
                }
            }

            var result = (isSuccess, data);
            return await Task.FromResult(result);
        }

        public async Task<(bool, List<MiscDataSelectionModel>)> RPTLPC_GetFleet(TransportationRequestCommonModel input)
        {
            input.selectShippingpoint = input.selectShippingpoint == null ? new List<string> { } : input.selectShippingpoint;
            input.selectBusiness = input.selectBusiness == null ? new List<string> { } : input.selectBusiness;
            input.selectFleet = input.selectFleet == null ? new List<int> { } : input.selectFleet;
            input.selectMatfreight = input.selectMatfreight == null ? new List<string> { } : input.selectMatfreight;
            input.selectRegion = input.selectRegion == null ? new List<string> { } : input.selectRegion;
            var isSuccess = false;
            var data = new List<MiscDataSelectionModel>();
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var datatmp = dbConnection.Query<MiscDataSelectionModel>($@"select 
						fleet_id as DataValue_Key, 
						fleet_name as DataDisplay 
						from dom.get_common_fleet(@selectFleet,null,@selectBusiness,@selectMatfreight,@selectShippingpoint,@selectRegion)",
                        param: new
                        {
                            input.selectFleet,
                            input.selectBusiness,
                            input.selectMatfreight,
                            input.selectShippingpoint,
                            input.selectRegion
                        });
                    data = datatmp.ToList();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                // NLog: catch any exception and log it.
                if (ex.InnerException != null)
                {
                    logger.Error(ex.InnerException, $"Exception on GetFleet");
                }
                else
                {
                    logger.Error(ex, $"Exception on GetFleet");
                }
            }

            var result = (isSuccess, data);
            return await Task.FromResult(result);
        }

        public async Task<(bool, List<MiscDataSelectionModel>)> RPTLPC_GetShippingPoint(TransportationRequestCommonModel input)
        {
            input.selectShippingpoint = input.selectShippingpoint == null ? new List<string> { } : input.selectShippingpoint;
            input.selectBusiness = input.selectBusiness == null ? new List<string> { } : input.selectBusiness;
            input.selectFleet = input.selectFleet == null ? new List<int> { } : input.selectFleet;
            input.selectMatfreight = input.selectMatfreight == null ? new List<string> { } : input.selectMatfreight;
            input.selectRegion = input.selectRegion == null ? new List<string> { } : input.selectRegion;
            var isSuccess = false;
            var data = new List<MiscDataSelectionModel>();
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var datatmp = dbConnection.Query<MiscDataSelectionModel>($@"select shipping_point_code as DataValue_Key
						, shipping_point_name as DataDisplay 
						from dom.get_common_shipping_point(@selectShippingpoint,null,@selectBusiness,@selectFleet,@selectMatfreight,@selectRegion)",
                        param: new
                        {
                            input.selectShippingpoint,
                            input.selectBusiness,
                            input.selectFleet,
                            input.selectMatfreight,
                            input.selectRegion

                        });
                    data = datatmp.ToList();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                // NLog: catch any exception and log it.
                if (ex.InnerException != null)
                {
                    logger.Error(ex.InnerException, $"Exception on GetShippingPoint");
                }
                else
                {
                    logger.Error(ex, $"Exception on GetShippingPoint");
                }
            }

            var result = (isSuccess, data);
            return await Task.FromResult(result);
        }

        public async Task<(bool, List<MiscDataSelectionModel>)> RPTLPC_GetShiptoRegion(TransportationRequestCommonModel input)
        {
            input.selectShippingpoint = input.selectShippingpoint == null ? new List<string> { } : input.selectShippingpoint;
            input.selectBusiness = input.selectBusiness == null ? new List<string> { } : input.selectBusiness;
            input.selectFleet = input.selectFleet == null ? new List<int> { } : input.selectFleet;
            input.selectMatfreight = input.selectMatfreight == null ? new List<string> { } : input.selectMatfreight;
            input.selectRegion = input.selectRegion == null ? new List<string> { } : input.selectRegion;
            var isSuccess = false;
            var data = new List<MiscDataSelectionModel>();
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var datatmp = dbConnection.Query<MiscDataSelectionModel>($@"select region_code as DataValue_Key, 
						region_name as DataDisplay 
						from dom.get_common_ddl_region(@selectRegion,null,@selectBusiness,@selectFleet,@selectMatfreight,@selectShippingpoint)",
                        param: new
                        {
                            input.selectRegion,
                            input.selectBusiness,
                            input.selectFleet,
                            input.selectMatfreight,
                            input.selectShippingpoint
                        });
                    data = datatmp.ToList();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                // NLog: catch any exception and log it.
                if (ex.InnerException != null)
                {
                    logger.Error(ex.InnerException, $"Exception on GetShipToRegion");
                }
                else
                {
                    logger.Error(ex, $"Exception on GetShipToRegion");
                }
            }

            var result = (isSuccess, data);
            return await Task.FromResult(result);
        }

        public async Task<(bool, List<MiscDataSelectionModel>)> RPTLPC_GetMatfrg(TransportationRequestCommonModel input)
        {
            input.selectShippingpoint = input.selectShippingpoint == null ? new List<string> { } : input.selectShippingpoint;
            input.selectBusiness = input.selectBusiness == null ? new List<string> { } : input.selectBusiness;
            input.selectFleet = input.selectFleet == null ? new List<int> { } : input.selectFleet;
            input.selectMatfreight = input.selectMatfreight == null ? new List<string> { } : input.selectMatfreight;
            input.selectRegion = input.selectRegion == null ? new List<string> { } : input.selectRegion;
            var isSuccess = false;
            var data = new List<MiscDataSelectionModel>();
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var datatmp = dbConnection.Query<MiscDataSelectionModel>(@$"select mat_freight_group_code as DataValue_Key,
						mat_freight_group_name as DataDisplay 
						from dom.get_common_mat_freight_group(@selectMatfreight,null,@selectBusiness,@selectFleet,@selectShippingpoint,@selectRegion)",
                        param: new
                        {
                            input.selectMatfreight,
                            input.selectBusiness,
                            input.selectFleet,
                            input.selectShippingpoint,
                            input.selectRegion
                        });
                    data = datatmp.ToList();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                // NLog: catch any exception and log it.
                if (ex.InnerException != null)
                {
                    logger.Error(ex.InnerException, $"Exception on GetMatfag");
                }
                else
                {
                    logger.Error(ex, $"Exception on GetMatfag");
                }
            }

            var result = (isSuccess, data);
            return await Task.FromResult(result);
        }

        public async Task<(bool, List<MiscDataSelectionModel>)> RPTLPC_GetOrderType(string order_type_name)
        {
            var isSuccess = false;
            var data = new List<MiscDataSelectionModel>();
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var datatmp = dbConnection.Query<MiscDataSelectionModel>("select order_type_name as DataValue_Key, order_type_name as DataDisplay from dom.get_common_order_type()");
                    data = datatmp.ToList();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                // NLog: catch any exception and log it.
                if (ex.InnerException != null)
                {
                    logger.Error(ex.InnerException, $"Exception on GetOrderType");
                }
                else
                {
                    logger.Error(ex, $"Exception on GetOrderType");
                }
            }

            var result = (isSuccess, data);
            return await Task.FromResult(result);
        }

        public async Task<(bool, List<MiscDataSelectionModel>)> RPTLPC_GetTruckType(string equipment_type_code)
        {
            var isSuccess = false;
            var data = new List<MiscDataSelectionModel>();
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var datatmp = dbConnection.Query<MiscDataSelectionModel>("select equipment_type_code as DataValue_Key, equipment_type_name as DataDisplay from dom.get_common_equipment_type()");
                    data = datatmp.ToList();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                // NLog: catch any exception and log it.
                if (ex.InnerException != null)
                {
                    logger.Error(ex.InnerException, $"Exception on GetTruckType");
                }
                else
                {
                    logger.Error(ex, $"Exception on GetTruckType");
                }
            }

            var result = (isSuccess, data);
            return await Task.FromResult(result);
        }

        public async Task<(bool, List<MiscDataSelectionModel>)> RPTLPC_GetPlannerName(string planner_name)
        {
            var isSuccess = false;
            var data = new List<MiscDataSelectionModel>();
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var datatmp = dbConnection.Query<MiscDataSelectionModel>("select planner_name as DataValue_Key, planner_name as DataDisplay from dom.get_common_planner_name()");
                    data = datatmp.ToList();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                // NLog: catch any exception and log it.
                if (ex.InnerException != null)
                {
                    logger.Error(ex.InnerException, $"Exception on GetPlannerName");
                }
                else
                {
                    logger.Error(ex, $"Exception on GetPlannerName");
                }
            }

            var result = (isSuccess, data);
            return await Task.FromResult(result);
        }

        public async Task<(bool, List<MiscDataSelectionModel>)> RPTLPC_GetOrderPlannerName(string planner_name)
        {
            var isSuccess = false;
            var data = new List<MiscDataSelectionModel>();
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var datatmp = dbConnection.Query<MiscDataSelectionModel>("select planner_name as DataValue_Key, planner_name as DataDisplay from dom.get_common_order_planner_name()");
                    data = datatmp.ToList();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                // NLog: catch any exception and log it.
                if (ex.InnerException != null)
                {
                    logger.Error(ex.InnerException, $"Exception on GetPlannerName");
                }
                else
                {
                    logger.Error(ex, $"Exception on GetPlannerName");
                }
            }

            var result = (isSuccess, data);
            return await Task.FromResult(result);
        }

        public async Task<(bool, List<MiscDataTestComboModel>)> RPTLPC_GetOrderPlannerNameTest(string planner_name, string term)
        {
            var isSuccess = false;
            var data = new List<MiscDataTestComboModel>();
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var datatmp = dbConnection.Query<MiscDataTestComboModel>("select planner_name as id, planner_name as text from dom.get_common_planner_name(@term)",
                        param: new
                        {
                            term
                        });
                    data = datatmp.ToList();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                // NLog: catch any exception and log it.
                if (ex.InnerException != null)
                {
                    logger.Error(ex.InnerException, $"Exception on GetPlannerName");
                }
                else
                {
                    logger.Error(ex, $"Exception on GetPlannerName");
                }
            }

            var result = (isSuccess, data);
            return await Task.FromResult(result);
        }

        public List<RPTCDC007ReportForLPCViewModel> RPT007_ReportForLPC(DateTime selectStartDate, DateTime selectEndDate, List<int> selectCustomer)
        {
            selectCustomer = selectCustomer == null ? new List<int> { } : selectCustomer;
            selectStartDate.ToString("yyyy-MM-dd");
            selectEndDate.ToString("yyyy-MM-dd");
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTCDC007ReportForLPCViewModel>($@"select 
                        curr_date,
                        do_number,
                        customer_code,
                        product_code,
                        sum_qty,
                        sum_weight,
                        sum_volumn,
                        route_id,
                        customer_name,
                        customer_address,
                        city,
                        province,
                        actual_weight,
                        ship_by,
                        route_line_no,
                        pallet_id,
                        shipping_mark,
                        shipto_sub_code,
                        request_date,
                        tu_number,
                        service_type   
                    from wh.getreport09('{{{string.Join(",", selectCustomer.ToArray())}}}', '{selectStartDate}', '{selectEndDate}')", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        public List<RPTESC003InventoryInquiryViewModel> RPTESC003_InventoryInquiryReport(DateTime selectStartDate, DateTime selectEndDate, List<int> selectCustomer)
        {
            selectCustomer = selectCustomer == null ? new List<int> { } : selectCustomer;
            selectStartDate.ToString("yyyy-MM-dd");
            selectEndDate.ToString("yyyy-MM-dd");
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTESC003InventoryInquiryViewModel>($@"select warehouse,  
                    location,  
                    pallet_no,  
                    tag_no,  
                    product_code,  
                    product_name,  
                    product_condition,  
                    inventory_qty,  
                    balance_qty,  
                    unit_code,  
                    bin_block,  
                    product_group,  
                    serial,  
                    lot_no,  
                    weight,  
                    volumn,  
                    received_date,  
                    expired_date,  
                    mfg_date,  
                    last_movement,  
                    po_no,  
                    invoice_no,  
                    doc_type  
                    from wh.getreport04_esc('{{{string.Join(",", selectCustomer.ToArray())}}}', '{selectStartDate}', '{selectEndDate}')", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        //public List<RPTESC004CheckMoveViewModel> RPTESC004_CheckMoveReport(DateTime selectStartDate, DateTime selectEndDate, List<int> selectCustomer)
        //{
        //    selectCustomer = selectCustomer == null ? new List<int> { } : selectCustomer;
        //    selectStartDate.ToString("yyyy-MM-dd");
        //    selectEndDate.ToString("yyyy-MM-dd");
        //    try
        //    {
        //        using (IDbConnection dbConnection = Connection)
        //        {
        //            dbConnection.Open();
        //            var data = dbConnection.Query<RPTESC004CheckMoveViewModel>($@"select  
        //        doc_no, 
        //        item, 
        //        doc_year, 
        //        inventory_status, 
        //        storage_bin, 
        //        product, 
        //        product_desc, 
        //        high_level_hu, 
        //        inventory_qty, 
        //        book_qty, 
        //        counted_qty, 
        //        diff_qty, 
        //        counted_date, 
        //        counted_time, 
        //        count_user, 
        //        zero_count 
        //         from wh.getreport06_esc('{{{string.Join(",", selectCustomer.ToArray())}}}', '{selectStartDate}', '{selectEndDate}')", commandTimeout: 3000);
        //            return data.ToList();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        logger.Error(ex, ex.Message);
        //        return null;
        //    }
        //}

        public List<RPTCDC001CompareReceivingChartViewModel> RPTCDC001_CompareReceivingChart(WarehouseCDCRequestDateModel input)
        {
            input.selectCustomer = input.selectCustomer == null ? new List<string> { } : input.selectCustomer;
            input.selectDc = input.selectDc == null ? new List<string> { } : input.selectDc;
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTCDC001CompareReceivingChartViewModel>($@"select 
                    customer_name,
                    total_qty_today,
                    received_qty_today,
                    putaway_qty_today,
                    putaway_percent,
                    not_putaway_qty
                    from wh.getreport01_received_qty('{input.selectStartDate}', '{input.selectEndDate}','{{{string.Join(",", input.selectDc.ToArray())}}}','{{{string.Join(",", input.selectCustomer.ToArray())}}}','{input.CountBy}')", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        public List<RPTESC001CompareReceivingChartViewModel> RPTESC001_CompareReceivingChart(WarehouseESCRequestDateModel input)
        {
            input.selectCustomer = input.selectCustomer == null ? new List<int> { } : input.selectCustomer;
            input.selectDc = input.selectDc == null ? new List<int> { } : input.selectDc;
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTESC001CompareReceivingChartViewModel>($@"select 
                    customer_name,
                    transport_type,
                    total_qty_today,
                    received_qty_today,
                    putaway_qty_today,
                    outstanding_qty_today,
                    putaway_percent,
                    not_putaway_qty
                    from wh.getreport01_esc_received_qty('{input.selectStartDate}', '{input.selectEndDate}','{{{string.Join(",", input.selectDc.ToArray())}}}','{{{string.Join(",", input.selectCustomer.ToArray())}}}','{input.CountBy}')", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        public List<RPTCDC003DispatchByCustomerTimeViewModel> RPTCDC003DispatchByCustomerTimeChart(WarehouseCDCRequestDateModel input)
        {
            input.selectCustomer = input.selectCustomer == null ? new List<string> { } : input.selectCustomer;
            input.selectDc = input.selectDc == null ? new List<string> { } : input.selectDc;
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTCDC003DispatchByCustomerTimeViewModel>($@"select 
                dispatch_time,
                customer_name,
                dispatch_qty
                from wh.getreport03_dispatch_by_customer_time('{input.selectStartDate}', '{input.selectEndDate}','{{{string.Join(",", input.selectDc.ToArray())}}}','{{{string.Join(",", input.selectCustomer.ToArray())}}}','{input.CountBy}')", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }
        public List<RPTCDC003DispatchByCustomerTimeViewModel> RPTCDC003DispatchByCustomerCreateTimeChart(WarehouseCDCRequestDateModel input)
        {
            input.selectCustomer = input.selectCustomer == null ? new List<string> { } : input.selectCustomer;
            input.selectDc = input.selectDc == null ? new List<string> { } : input.selectDc;
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTCDC003DispatchByCustomerTimeViewModel>($@"select 
                dispatch_time,
                customer_name,
                dispatch_qty
                from wh.getreport03_dispatch_by_customer_createtime('{input.selectStartDate}', '{input.selectEndDate}','{{{string.Join(",", input.selectDc.ToArray())}}}','{{{string.Join(",", input.selectCustomer.ToArray())}}}','{input.CountBy}')", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }
        public List<RPTESC002DispatchByCustomerTimeViewModel> RPTESC002DispatchByCustomerTimeChart(WarehouseESCRequestDateModel input)
        {
            input.selectCustomer = input.selectCustomer == null ? new List<int> { } : input.selectCustomer;
            input.selectDc = input.selectDc == null ? new List<int> { } : input.selectDc;
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTESC002DispatchByCustomerTimeViewModel>($@"select 
                dispatch_time,
                customer_name,
                dispatch_qty
                from wh.getreport03_esc_dispatch_by_customer_time('{input.selectStartDate}', '{input.selectEndDate}','{{{string.Join(",", input.selectDc.ToArray())}}}','{{{string.Join(",", input.selectCustomer.ToArray())}}}','{input.CountBy}')", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        public List<RPTCDC003DispatchByTimeViewModel> RPTCDC003DispatchByTimeChart(WarehouseCDCRequestDateModel input)
        {
            input.selectCustomer = input.selectCustomer == null ? new List<string> { } : input.selectCustomer;
            input.selectDc = input.selectDc == null ? new List<string> { } : input.selectDc;
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTCDC003DispatchByTimeViewModel>($@"select 
                dispatch_time,
                total_qty
                from wh.getreport03_dispatch_by_time('{input.selectStartDate}', '{input.selectEndDate}','{{{string.Join(",", input.selectDc.ToArray())}}}','{{{string.Join(",", input.selectCustomer.ToArray())}}}','{input.CountBy}')", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }
        public List<RPTESC002DispatchByTimeViewModel> RPTESC002DispatchByTimeChart(WarehouseESCRequestDateModel input)
        {
            input.selectCustomer = input.selectCustomer == null ? new List<int> { } : input.selectCustomer;
            input.selectDc = input.selectDc == null ? new List<int> { } : input.selectDc;
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTESC002DispatchByTimeViewModel>($@"select 
                dispatch_time,
                total_qty
                from wh.getreport03_esc_dispatch_by_time('{input.selectStartDate}', '{input.selectEndDate}','{{{string.Join(",", input.selectDc.ToArray())}}}','{{{string.Join(",", input.selectCustomer.ToArray())}}}','{input.CountBy}')", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }
        public List<RPTCDC001ReceivedByTimeViewModel> RPTCDC001ReceivedByTimePieChart(WarehouseCDCRequestDateModel input)
        {
            input.selectCustomer = input.selectCustomer == null ? new List<string> { } : input.selectCustomer;
            input.selectDc = input.selectDc == null ? new List<string> { } : input.selectDc;
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTCDC001ReceivedByTimeViewModel>($@"select 
                received_time,
                total_qty
                from wh.getreport01_received_by_time('{input.selectStartDate}', '{input.selectEndDate}','{{{string.Join(",", input.selectDc.ToArray())}}}','{{{string.Join(",", input.selectCustomer.ToArray())}}}','{input.CountBy}')", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }
        public List<RPTESC001ReceivedByTimeViewModel> RPTESC001ReceivedByTimePieChart(WarehouseESCRequestDateModel input)
        {
            input.selectCustomer = input.selectCustomer == null ? new List<int> { } : input.selectCustomer;
            input.selectDc = input.selectDc == null ? new List<int> { } : input.selectDc;
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTESC001ReceivedByTimeViewModel>($@"select 
                received_time,
                total_ton
                from wh.getreport01_esc_received_by_time('{input.selectStartDate}', '{input.selectEndDate}','{{{string.Join(",", input.selectDc.ToArray())}}}','{{{string.Join(",", input.selectCustomer.ToArray())}}}','{input.CountBy}')", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }


        public List<RPTCDC001ReceivedSummaryViewModel> RPTCDC001ReceivedSummary(WarehouseCDCRequestDateModel input)
        {
            input.selectCustomer = input.selectCustomer == null ? new List<string> { } : input.selectCustomer;
            input.selectDc = input.selectDc == null ? new List<string> { } : input.selectDc;
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTCDC001ReceivedSummaryViewModel>($@"select 
                    dc_name,
                    total_order,
                    received_order,
                    outstanding_order
                    from wh.getreport01_received_order('{input.selectStartDate}', '{input.selectEndDate}','{{{string.Join(",", input.selectDc.ToArray())}}}','{{{string.Join(",", input.selectCustomer.ToArray())}}}','{input.CountBy}')", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        public List<RPTESC001ReceivedSummaryViewModel> RPTESC001ReceivedSummary(WarehouseESCRequestDateModel input)
        {
            input.selectCustomer = input.selectCustomer == null ? new List<int> { } : input.selectCustomer;
            input.selectDc = input.selectDc == null ? new List<int> { } : input.selectDc;
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTESC001ReceivedSummaryViewModel>($@"select 
                    dc_name,
                    total_order,
                    received_order,
                    outstanding_order
                    from wh.getreport01_esc_received_order('{input.selectStartDate}', '{input.selectEndDate}','{{{string.Join(",", input.selectDc.ToArray())}}}','{{{string.Join(",", input.selectCustomer.ToArray())}}}','{input.CountBy}')", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        public List<RPTCDC001ReceivedSummaryTableViewModel> RPTCDC001ReceivedSummaryTable(WarehouseCDCRequestDateModel input)
        {
            input.selectCustomer = input.selectCustomer == null ? new List<string> { } : input.selectCustomer;
            input.selectDc = input.selectDc == null ? new List<string> { } : input.selectDc;
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTCDC001ReceivedSummaryTableViewModel>($@"select 
                    customer_name,
                    total_qty_today,
                    issue_qty,
					incomplete_received_qty,
					received_qty_today,                    
					putaway_qty_today,
                    putaway_percent,
                    not_putaway_qty
                    from wh.getreport01_received_qty('{input.selectStartDate}', '{input.selectEndDate}','{{{string.Join(",", input.selectDc.ToArray())}}}','{{{string.Join(",", input.selectCustomer.ToArray())}}}','{input.CountBy}')", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        public List<RPTESC001ReceivedSummaryTableViewModel> RPTESC001ReceivedSummaryTable(WarehouseESCRequestDateModel input)
        {
            input.selectCustomer = input.selectCustomer == null ? new List<int> { } : input.selectCustomer;
            input.selectDc = input.selectDc == null ? new List<int> { } : input.selectDc;
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTESC001ReceivedSummaryTableViewModel>($@"select 
                    customer_name,
                    transport_type,
                    total_qty_today,
                    received_qty_today,
                    putaway_qty_today,
                    outstanding_qty_today,
                    putaway_percent,
                    not_putaway_qty
                    from wh.getreport01_esc_received_qty('{input.selectStartDate}', '{input.selectEndDate}','{{{string.Join(",", input.selectDc.ToArray())}}}','{{{string.Join(",", input.selectCustomer.ToArray())}}}','{input.CountBy}')", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        public async Task<(bool, List<MiscDataSelectionModel>)> RPTWH_GetDC(string selectDcType)
        {
            var isSuccess = false;
            var data = new List<MiscDataSelectionModel>();
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var datatmp = dbConnection.Query<MiscDataSelectionModel>($@"select dc_code as DataValue_Key, 
                        dc_code ||':'|| dc_name as DataDisplay  
                        from wh.get_common_dc(null,null,null,'{selectDcType}')");
                    data = datatmp.ToList();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                // NLog: catch any exception and log it.
                if (ex.InnerException != null)
                {
                    logger.Error(ex.InnerException, $"Exception on MaintainAccountCodeTransaction");
                }
                else
                {
                    logger.Error(ex, $"Exception on MaintainAccountCodeTransaction");
                }
            }

            var result = (isSuccess, data);
            return await Task.FromResult(result);
        }

        public async Task<(bool, List<MiscDataSelectionModel>)> RPTWHESC_GetDC(string selectDcType)
        {
            var isSuccess = false;
            var data = new List<MiscDataSelectionModel>();
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var datatmp = dbConnection.Query<MiscDataSelectionModel>($@"select dcid as DataValue_Key, 
                        dc_name as DataDisplay  
                        from wh.get_common_dc(null,null,null,'{selectDcType}')");
                    data = datatmp.ToList();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                // NLog: catch any exception and log it.
                if (ex.InnerException != null)
                {
                    logger.Error(ex.InnerException, $"Exception on MaintainAccountCodeTransaction");
                }
                else
                {
                    logger.Error(ex, $"Exception on MaintainAccountCodeTransaction");
                }
            }

            var result = (isSuccess, data);
            return await Task.FromResult(result);
        }

        public List<RPTCDC003DispatchSummaryViewModel> RPTCDC003DispatchSummary(WarehouseCDCRequestDateModel input)
        {
            input.selectCustomer = input.selectCustomer == null ? new List<string> { } : input.selectCustomer;
            input.selectDc = input.selectDc == null ? new List<string> { } : input.selectDc;
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTCDC003DispatchSummaryViewModel>($@"select 
                    dc_name,
                    total_order,
                    dispatch_order,
                    outstanding_order
                    from wh.getreport03_dispatch_order('{input.selectStartDate}', '{input.selectEndDate}','{{{string.Join(",", input.selectDc.ToArray())}}}','{{{string.Join(",", input.selectCustomer.ToArray())}}}','{input.CountBy}')", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }
        public List<RPTESC002DispatchSummaryViewModel> RPTESC002DispatchSummary(WarehouseESCRequestDateModel input)
        {
            input.selectCustomer = input.selectCustomer == null ? new List<int> { } : input.selectCustomer;
            input.selectDc = input.selectDc == null ? new List<int> { } : input.selectDc;
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTESC002DispatchSummaryViewModel>($@"select 
                    dc_name,
                    total_order,
                    total_trip,
                    dispatch_order,
                    dispatch_trip,
                    outstanding_order,
                    outstanding_trip
                    from wh.getreport03_esc_dispatch_order('{input.selectStartDate}', '{input.selectEndDate}','{{{string.Join(",", input.selectDc.ToArray())}}}','{{{string.Join(",", input.selectCustomer.ToArray())}}}','{input.CountBy}')", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        public List<RPTCDC003CompareDispatchChartViewModel> RPTCDC003_CompareDispatchChart(WarehouseCDCRequestDateModel input)
        {
            input.selectCustomer = input.selectCustomer == null ? new List<string> { } : input.selectCustomer;
            input.selectDc = input.selectDc == null ? new List<string> { } : input.selectDc;
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTCDC003CompareDispatchChartViewModel>($@"select 
					customer_name,
                    plan_qty,
                    pick_qty,
                    ship_qty,
                    gi_qty,
                    gi_percent,
                    not_gi_qty
					from wh.getreport03_dispatch_qty_status('{input.selectStartDate}', '{input.selectEndDate}','{{{string.Join(",", input.selectDc.ToArray())}}}','{{{string.Join(",", input.selectCustomer.ToArray())}}}','{input.CountBy}')", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }
        public List<RPTESC002CompareDispatchChartViewModel> RPTESC002_CompareDispatchChart(WarehouseESCRequestDateModel input)
        {
            input.selectCustomer = input.selectCustomer == null ? new List<int> { } : input.selectCustomer;
            input.selectDc = input.selectDc == null ? new List<int> { } : input.selectDc;
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTESC002CompareDispatchChartViewModel>($@"select 
					customer_name,
                    transport_type,
                    plan_qty,
                    pick_qty,
                    ship_qty,
                    gi_qty,
                    outstanding_qty,
                    gi_percent,
                    not_gi_qty
					from wh.getreport03_esc_dispatch_qty_status('{input.selectStartDate}', '{input.selectEndDate}','{{{string.Join(",", input.selectDc.ToArray())}}}','{{{string.Join(",", input.selectCustomer.ToArray())}}}','{input.CountBy}')", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        public List<RPTCDC003DispatchSummaryTableViewModel> RPTCDC003_DispatchSummaryTable(WarehouseCDCRequestDateModel input)
        {
            input.selectCustomer = input.selectCustomer == null ? new List<string> { } : input.selectCustomer;
            input.selectDc = input.selectDc == null ? new List<string> { } : input.selectDc;
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTCDC003DispatchSummaryTableViewModel>($@"select
					customer_name,
                    plan_qty,
					new_qty,
					book_qty,
					issue_qty,
					incomplete_pick_qty,
					pick_qty,
					incomplete_ship_qty,
					ship_qty,
					gi_qty,
					gi_percent,
					not_gi_qty
					from wh.getreport03_dispatch_qty_status('{input.selectStartDate}', '{input.selectEndDate}','{{{string.Join(",", input.selectDc.ToArray())}}}','{{{string.Join(",", input.selectCustomer.ToArray())}}}','{input.CountBy}')", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }
        public List<RPTESC002DispatchSummaryTableViewModel> RPTESC002_DispatchSummaryTable(WarehouseESCRequestDateModel input)
        {
            input.selectCustomer = input.selectCustomer == null ? new List<int> { } : input.selectCustomer;
            input.selectDc = input.selectDc == null ? new List<int> { } : input.selectDc;
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTESC002DispatchSummaryTableViewModel>($@"select
					customer_name,
                    transport_type,
                    plan_qty,
                    plan_trip,
                    pick_qty,
                    pick_trip,
                    ship_qty,
                    ship_trip,
                    gi_qty,
                    gi_trip,
                    outstanding_qty,
                    outstanding_trip,
                    gi_percent,
                    not_gi_qty,
                    not_gi_trip
					from wh.getreport03_esc_dispatch_qty_status('{input.selectStartDate}', '{input.selectEndDate}','{{{string.Join(",", input.selectDc.ToArray())}}}','{{{string.Join(",", input.selectCustomer.ToArray())}}}')", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        public List<RPTCDC002StockSummaryViewModel> RPTCDC002_StockSummary(WarehouseRequestStockModel input)
        {
            string[] Customer = input.selectCustomer?.ToArray() ?? new string[] { };
            string[] DC = input.selectDc?.ToArray() ?? new string[] { };
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTCDC002StockSummaryViewModel>($@"select
					dc_name,
                    total_location,
                    used_location,
                    avaliable_location,
                    qty,
                    used_percent,
                    avaliable_percent
					from wh.getreport02_stock_status()", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }
        public List<RPTESC003StockSummaryViewModel> RPTESC003_StockSummary(WarehouseESCRequestStockModel input)
        {
            input.selectCustomer = input.selectCustomer == null ? new List<int> { } : input.selectCustomer;
            input.selectDc = input.selectDc == null ? new List<int> { } : input.selectDc;
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTESC003StockSummaryViewModel>($@"select
					dc_name,
                    total_location,
                    used_location,
                    avaliable_location,
                    qty,
                    used_percent,
                    avaliable_percent
					from wh.getreport02_esc_stock_status('{input.selectDate}','{{{string.Join(",", input.selectDc.ToArray())}}}','{{{string.Join(",", input.selectCustomer.ToArray())}}}')", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        public List<RPTCDC001ReceivedByCustomerTimeViewModel> RPTCDC001ReceivedByCustomerTimeBarChart(WarehouseCDCRequestDateModel input)
        {
            input.selectCustomer = input.selectCustomer == null ? new List<string> { } : input.selectCustomer;
            input.selectDc = input.selectDc == null ? new List<string> { } : input.selectDc;
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTCDC001ReceivedByCustomerTimeViewModel>($@"select 
                    received_time,
                    customer_name,
                    received_qty
                    from wh.getreport01_received_by_customer_time('{input.selectStartDate}', '{input.selectEndDate}','{{{string.Join(",", input.selectDc.ToArray())}}}','{{{string.Join(",", input.selectCustomer.ToArray())}}}','{input.CountBy}')", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        public List<RPTCDC001ReceivedByCustomerTimeViewModel> RPTCDC001ReceivedByReceivedTimeBarChart(WarehouseCDCRequestDateModel input)
        {
            input.selectCustomer = input.selectCustomer == null ? new List<string> { } : input.selectCustomer;
            input.selectDc = input.selectDc == null ? new List<string> { } : input.selectDc;
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTCDC001ReceivedByCustomerTimeViewModel>($@"select 
                    received_time,
                    customer_name,
                    received_qty
                    from wh.getreport01_received_by_customer_receivedtime('{input.selectStartDate}', '{input.selectEndDate}','{{{string.Join(",", input.selectDc.ToArray())}}}','{{{string.Join(",", input.selectCustomer.ToArray())}}}','{input.CountBy}')", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }
        public List<RPTESC001ReceivedByCustomerTimeViewModel> RPTESC001ReceivedByCustomerTimeBarChart(WarehouseESCRequestDateModel input)
        {
            input.selectCustomer = input.selectCustomer == null ? new List<int> { } : input.selectCustomer;
            input.selectDc = input.selectDc == null ? new List<int> { } : input.selectDc;
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTESC001ReceivedByCustomerTimeViewModel>($@"select 
                    received_time,
                    customer_name,
                    received_ton
                    from wh.getreport01_esc_received_by_customer_time('{input.selectStartDate}', '{input.selectEndDate}','{{{string.Join(",", input.selectDc.ToArray())}}}','{{{string.Join(",", input.selectCustomer.ToArray())}}}','{input.CountBy}')", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        public List<RPTCDC005PickPackSummaryViewModel> RPTCDC005_PickPackSummary(WarehouseRequestPickPackModel input)
        {
            input.selectCustomer = input.selectCustomer == null ? new List<string> { } : input.selectCustomer;
            input.selectProductGroup = input.selectProductGroup == null ? new List<string> { } : input.selectProductGroup;
            input.selectDc = input.selectDc == null ? new List<string> { } : input.selectDc;
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTCDC005PickPackSummaryViewModel>($@"select 
                    dc_name,
                    pick_qty,
                    pack_qty
                    from wh.getreport05_pickpack_qty('{input.selectPickStartDate}', '{input.selectPickEndDate}','{input.selectPackStartDate}', '{input.selectPackEndDate}','{{{string.Join(",", input.selectDc.ToArray())}}}','{{{string.Join(",", input.selectCustomer.ToArray())}}}','{{{string.Join(",", input.selectProductGroup.ToArray())}}}')", commandTimeout: 0);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        public List<RPTESC005PickPackSummaryViewModel> RPTESC005_PickPackSummary(WarehouseESCRequestPickPackModel input)
        {
            input.selectCustomer = input.selectCustomer == null ? new List<int> { } : input.selectCustomer;
            input.selectDc = input.selectDc == null ? new List<int> { } : input.selectDc;
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTESC005PickPackSummaryViewModel>($@"select 
                    dc_name,
                    pick_ton,
                    pack_qty
                    from wh.getreport05_esc_pickpack_qty('{input.selectPickStartDate}', '{input.selectPickEndDate}','{input.selectPackStartDate}', '{input.selectPackEndDate}','{{{string.Join(",", input.selectDc.ToArray())}}}','{{{string.Join(",", input.selectCustomer.ToArray())}}}')", commandTimeout: 0);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        public List<RPTCDC005PickByCustomerViewModel> RPTCDC005_PickByCustomer(WarehouseRequestPickPackModel input)
        {
            input.selectCustomer = input.selectCustomer == null ? new List<string> { } : input.selectCustomer;
            input.selectProductGroup = input.selectProductGroup == null ? new List<string> { } : input.selectProductGroup;
            input.selectDc = input.selectDc == null ? new List<string> { } : input.selectDc;
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTCDC005PickByCustomerViewModel>($@"select 
					pick_date,
                    customer_name,
                    pick_qty
                    from wh.getreport05_pick_by_customer('{input.selectPickStartDate}', '{input.selectPickEndDate}','{{{string.Join(",", input.selectDc.ToArray())}}}','{{{string.Join(",", input.selectCustomer.ToArray())}}}','{{{string.Join(",", input.selectProductGroup.ToArray())}}}')", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }
        public List<RPTESC005PickByCustomerViewModel> RPTESC005_PickByCustomer(WarehouseESCRequestPickPackModel input)
        {
            input.selectCustomer = input.selectCustomer == null ? new List<int> { } : input.selectCustomer;
            input.selectDc = input.selectDc == null ? new List<int> { } : input.selectDc;
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTESC005PickByCustomerViewModel>($@"select 
                    customer_name,
                    pick_ton
                    from wh.getreport05_esc_pick_by_customer('{input.selectPickStartDate}', '{input.selectPickEndDate}','{{{string.Join(",", input.selectDc.ToArray())}}}','{{{string.Join(",", input.selectCustomer.ToArray())}}}')", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        public List<RPTCDC005PackByCustomerViewModel> RPTCDC005_PackByCustomer(WarehouseRequestPickPackModel input)
        {
            input.selectCustomer = input.selectCustomer == null ? new List<string> { } : input.selectCustomer;
            input.selectProductGroup = input.selectProductGroup == null ? new List<string> { } : input.selectProductGroup;
            input.selectDc = input.selectDc == null ? new List<string> { } : input.selectDc;
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTCDC005PackByCustomerViewModel>($@"select 
					pack_date,
                    customer_name,
                    pack_qty
                    from wh.getreport05_pack_by_customer('{input.selectPackStartDate}', '{input.selectPackEndDate}','{{{string.Join(",", input.selectDc.ToArray())}}}','{{{string.Join(",", input.selectCustomer.ToArray())}}}','{{{string.Join(",", input.selectProductGroup.ToArray())}}}')", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        public List<RPTESC005PackByCustomerViewModel> RPTESC005_PackByCustomer(WarehouseESCRequestPickPackModel input)
        {
            input.selectCustomer = input.selectCustomer == null ? new List<int> { } : input.selectCustomer;
            input.selectDc = input.selectDc == null ? new List<int> { } : input.selectDc;
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTESC005PackByCustomerViewModel>($@"select 
                    customer_name,
                    pack_qty
                    from wh.getreport05_esc_pack_by_customer('{input.selectPackStartDate}', '{input.selectPackEndDate}','{{{string.Join(",", input.selectDc.ToArray())}}}','{{{string.Join(",", input.selectCustomer.ToArray())}}}')", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        public List<RPTCDC005PickPackViewModel> RPTCDC005_PickPackReport(WarehouseRequestPickPackModel input)
        {

            string[] dc = input.selectDc?.ToArray() ?? new string[] { };
            string[] Customer = input.selectCustomer?.ToArray() ?? new string[] { };
            string[] ProductGroup = input.selectProductGroup?.ToArray() ?? new string[] { };
            DateTime pickDateFrom = DateTime.Parse(input.selectPickStartDate);
            DateTime pickDateTo = DateTime.Parse(input.selectPickEndDate);
            DateTime packDateFrom = DateTime.Parse(input.selectPackStartDate);
            DateTime packDateTo = DateTime.Parse(input.selectPackEndDate);

            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTCDC005PickPackViewModel>($@"select picking_date, 
                invoice_no, 
                final_destination_code, 
                final_destination_name, 
                city, 
                province, 
                weight, 
                volumn, 
                installment, 
                shipment_no, 
                product_id, 
                doc_no, 
                type_code, 
                type_name, 
                doc_type, 
                ship_qty, 
                picking_no, 
                product_barcode, 
                product_code, 
                product_name, 
                pick_qty, 
                unit_code, 
                perpcs, 
                uomtn, 
                pcs2, 
                pick_unit_charge, 
                pick_charge_unit, 
                pick_charge_item, 
                packing_no, 
                pack_date, 
                shipping_mark, 
                package_code, 
                package_name, 
                box_no, 
                pack_qty, 
                pack_charge_unit, 
                pack_charge_item, 
                void_no, 
                void_charge  
                from wh.getreport05_trans(@pickDateFrom::date,@pickDateTo::date,@packDateFrom::date,@packDateTo::date,@dc,@Customer,@selectCustomerName,@ProductGroup)",
                param: new
                {
                    pickDateFrom,
                    pickDateTo,
                    packDateFrom,
                    packDateTo,
                    dc,
                    Customer,
                    input.selectCustomerName,
                    ProductGroup
                }
                , commandTimeout: 0);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        public List<RPTESC005PickPackViewModel> RPTESC005_PickPackReport(WarehouseESCRequestPickPackModel input)
        {
            int[] dc = input.selectDc?.ToArray() ?? new int[] { };
            int[] Customer = input.selectCustomer?.ToArray() ?? new int[] { };
            DateTime pickDateFrom = DateTime.Parse(input.selectPickStartDate);
            DateTime pickDateTo = DateTime.Parse(input.selectPickEndDate);
            DateTime packDateFrom = DateTime.Parse(input.selectPackStartDate);
            DateTime packDateTo = DateTime.Parse(input.selectPackEndDate);

            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTESC005PickPackViewModel>($@"select picking_date, 
                invoice_no, 
                final_destination_code, 
                final_destination_name, 
                city, 
                province, 
                weight, 
                volumn, 
                installment, 
                shipment_no, 
                product_id, 
                doc_no, 
                type_code, 
                type_name, 
                doc_type, 
                ship_qty, 
                picking_no, 
                product_barcode, 
                product_code, 
                product_name, 
                pick_qty, 
                unit_code, 
                perpcs, 
                uomtn, 
                pcs2, 
                pick_unit_charge, 
                pick_charge_unit, 
                pick_charge_item, 
                packing_no, 
                pack_date, 
                shipping_mark, 
                package_code, 
                package_name, 
                box_no, 
                pack_qty, 
                pack_charge_unit, 
                pack_charge_item, 
                void_no, 
                void_charge  
                from wh.getreport05_esc_trans(@pickDateFrom::date,@pickDateTo::date,@packDateFrom::date,@packDateTo::date,@dc,@Customer,@selectCustomerName)",
                param: new
                {
                    pickDateFrom,
                    pickDateTo,
                    packDateFrom,
                    packDateTo,
                    dc,
                    Customer,
                    input.selectCustomerName
                }
                , commandTimeout: 0);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        public List<RPTCDC006CheckMoveQtyViewModel> RPTCDC006_CheckMoveQty(WarehouseCDCRequestDateModel input)
        {
            input.selectCustomer = input.selectCustomer == null ? new List<string> { } : input.selectCustomer;
            input.selectDc = input.selectDc == null ? new List<string> { } : input.selectDc;
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTCDC006CheckMoveQtyViewModel>($@"select 
                    dc_name,
                    plan_qty,
                    count_qty,
                    accuracy
                    from wh.getreport06_checkmove_qty('{input.selectStartDate}','{input.selectEndDate}','{{{string.Join(",", input.selectDc.ToArray())}}}','{{{string.Join(",", input.selectCustomer.ToArray())}}}')", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }
        public List<RPTESC004CheckMoveQtyViewModel> RPTESC004_CheckMoveQty(WarehouseESCRequestDateModel input)
        {
            int[] dc = input.selectDc?.ToArray() ?? new int[] { };
            int[] customer = input.selectCustomer?.ToArray() ?? new int[] { };
            DateTime dateFrom = DateTime.Parse(input.selectStartDate);
            DateTime dateTo = DateTime.Parse(input.selectEndDate);
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTESC004CheckMoveQtyViewModel>($@"select 
                    dc_name,
                    plan_location,
                    count_location,
                    location_accuracy,
                    plan_weight,
                    count_weight,
                    weight_accuracy
                    from wh.getreport06_esc_checkmove_qty(@dateFrom::Date,@dateTo::Date,@dc,@customer,@selectCheckMove)",
                    param: new
                    {
                        dateFrom,
                        dateTo,
                        dc,
                        customer,
                        input.selectCheckMove
                    }
                    , commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }
        public List<RPTCDC006CheckMoveByLocationViewModel> RPTCDC006_CheckMoveByLocation(WarehouseCDCRequestDateModel input)
        {
            input.selectCustomer = input.selectCustomer == null ? new List<string> { } : input.selectCustomer;
            input.selectDc = input.selectDc == null ? new List<string> { } : input.selectDc;
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTCDC006CheckMoveByLocationViewModel>($@"select 
                    count_date,
                    location_type,
                    inventory_qty,
                    count_qty
                    from wh.getreport06_checkmove_by_location('{input.selectStartDate}','{input.selectEndDate}','{{{string.Join(",", input.selectDc.ToArray())}}}','{{{string.Join(",", input.selectCustomer.ToArray())}}}')", commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }
        public List<RPTESC004CheckMoveByLocationViewModel> RPTESC004_CheckMoveByLocation(WarehouseESCRequestDateModel input)
        {
            int[] dc = input.selectDc?.ToArray() ?? new int[] { };
            int[] customer = input.selectCustomer?.ToArray() ?? new int[] { };
            DateTime dateFrom = DateTime.Parse(input.selectStartDate);
            DateTime dateTo = DateTime.Parse(input.selectEndDate);
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTESC004CheckMoveByLocationViewModel>($@"select 
                    count_date,
                    location_type,
                    inventory_weight,
                    count_weight
                    from wh.getreport06_esc_checkmove_by_location(@dateFrom::date,@dateTo::date,@dc,@customer,@selectCheckMove)"
                    , param: new
                    {
                        dateFrom,
                        dateTo,
                        dc,
                        customer,
                        input.selectCheckMove
                    }
                    ,
                    commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        public List<RPTCDC006CheckMoveViewModel> RPTCDC006_CheckMoveReport(WarehouseCDCRequestDateModel input)
        {
            string[] dc = input.selectDc?.ToArray() ?? new string[] { };
            string[] customer = input.selectCustomer?.ToArray() ?? new string[] { };
            DateTime dateFrom = DateTime.Parse(input.selectStartDate);
            DateTime dateTo = DateTime.Parse(input.selectEndDate);
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTCDC006CheckMoveViewModel>($@"select  
                doc_no, 
                item, 
                doc_year, 
                inventory_status, 
                storage_bin, 
                product, 
                product_desc, 
                high_level_hu, 
                inventory_qty, 
                book_qty, 
                counted_qty, 
                diff_qty, 
                counted_date, 
                counted_time, 
                count_user, 
                zero_count 
                 from wh.getreport06_trans(@dateFrom,@dateTo,@dc,@customer,@selectlocationType)",
                 param: new
                 {
                     dateFrom,
                     dateTo,
                     dc,
                     customer,
                     input.selectlocationType
                 }
                 , commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }
        public List<RPTESC004CheckMoveViewModel> RPTESC004_CheckMoveReport(WarehouseESCRequestDateModel input)
        {
            int[] dc = input.selectDc?.ToArray() ?? new int[] { };
            int[] customer = input.selectCustomer?.ToArray() ?? new int[] { };
            DateTime dateFrom = DateTime.Parse(input.selectStartDate);
            DateTime dateTo = DateTime.Parse(input.selectEndDate);
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTESC004CheckMoveViewModel>($@"select  
                doc_no, 
                item, 
                doc_year, 
                inventory_status, 
                storage_bin, 
                product, 
                product_desc, 
                high_level_hu, 
                inventory_qty, 
                book_qty, 
                counted_qty, 
                diff_qty, 
                counted_date, 
                counted_time, 
                count_user, 
                zero_count 
                 from wh.getreport06_esc_trans(@dateFrom,@dateTo,@dc,@customer,null,@selectCheckMove)",
                 param: new
                 {
                     dateFrom,
                     dateTo,
                     dc,
                     customer,
                     input.selectCheckMove
                 }
                 , commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }
        public List<RPTCDC000ReceiveAccuracyViewModel> RPTCDC000_ReceiveAccuracy(WarehouseOverAllRequestModel input)
        {
            string[] dc = input.selectDc?.ToArray() ?? new string[] { };
            string[] customer = input.selectCustomer?.ToArray() ?? new string[] { };
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTCDC000ReceiveAccuracyViewModel>($@"select
                    receive_date,
                    plan_order,
                    receive_order,
					plan_qty,
                    receive_qty
                 from wh.getoverall_receive_accuracy(@selectMonth,@selectYear,@dc,@customer)",
                 param: new
                 {
                     input.selectMonth,
                     input.selectYear,
                     dc,
                     customer
                 }
                 , commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        public List<RPTCDC000DispatchAccuracyViewModel> RPTCDC000_DispatchAccuracy(WarehouseOverAllRequestModel input)
        {
            string[] dc = input.selectDc?.ToArray() ?? new string[] { };
            string[] customer = input.selectCustomer?.ToArray() ?? new string[] { };
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTCDC000DispatchAccuracyViewModel>($@"select
                    dispatch_date,
                    plan_order,
                    dispatch_order,
					plan_qty,
                    dispatch_qty
                 from wh.getoverall_dispatch_accuracy(@selectMonth,@selectYear,@dc,@customer)",
                 param: new
                 {
                     input.selectMonth,
                     input.selectYear,
                     dc,
                     customer
                 }
                 , commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        public List<RPTCDC000ReceiveDispatchViewModel> RPTCDC000_ReceiveDispatch(WarehouseOverAllRequestModel input)
        {
            string[] dc = input.selectDc?.ToArray() ?? new string[] { };
            string[] customer = input.selectCustomer?.ToArray() ?? new string[] { };
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTCDC000ReceiveDispatchViewModel>($@"select
                    trans_date,
                    received_qty,
                    dispatch_qty,
					received_order,
                    dispatch_order
                 from wh.getoverall_receive_dispatch(@selectMonth,@selectYear,@dc,@customer)",
                 param: new
                 {
                     input.selectMonth,
                     input.selectYear,
                     dc,
                     customer
                 }
                 , commandTimeout: 3000);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        public List<RPTCDC000StockUtilizationViewModel> RPTCDC000_StockUtilization(WarehouseOverAllRequestModel input)
        {
            string[] dc = input.selectDc?.ToArray() ?? new string[] { };
            string[] customer = input.selectCustomer?.ToArray() ?? new string[] { };
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTCDC000StockUtilizationViewModel>($@"select
                    trans_date,
                    location_type,
                    total_location,
                    used_location
                 from wh.getoverall_stock_utilization(@selectMonth,@selectYear,@dc,@customer)",
                 param: new
                 {
                     input.selectMonth,
                     input.selectYear,
                     dc,
                     customer
                 }
                 , commandTimeout: 0);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        public List<RPTCDC000AgingProductViewModel> RPTCDC000_AgingProduct(WarehouseOverAllRequestModel input)
        {
            string[] dc = input.selectDc?.ToArray() ?? new string[] { };
            string[] customer = input.selectCustomer?.ToArray() ?? new string[] { };
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<RPTCDC000AgingProductViewModel>($@"select
                    trans_date,
                    location_type,
                    age1,
                    age2,
                    age3,
                    age4,
                    age5,
                    age6
                 from wh.getoverall_product_aging(@selectMonth,@selectYear,@dc,@customer)",
                 param: new
                 {
                     input.selectMonth,
                     input.selectYear,
                     dc,
                     customer
                 }
                 , commandTimeout: 0);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        public List<LineMessageModel> GetTransportationLineMessage01()
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var result = dbConnection.Query<LineMessageModel>($"SELECT * FROM dom.line_message_01_1();").ToList();
            result.AddRange(dbConnection.Query<LineMessageModel>($"SELECT * FROM dom.line_message_01_2();").ToList());
            result.AddRange(dbConnection.Query<LineMessageModel>($"SELECT * FROM dom.line_message_01_3();").ToList());

            return result;
        }

        public List<LineMessageModel> GetTransportationLineMessage02()
        {
            throw new NotImplementedException();
        }

        //public async Task<IEnumerable<TranshareModel>> ListAsync()
        //{
        //    var body = new { };
        //    var payload = new StringContent(
        //        JsonSerializer.Serialize(body),
        //        Encoding.UTF8,
        //        "applicaion/Json"
        //        );
        //    var xhr = await Client.PostAsync(string.Empty, payload);
        //    var data = await xhr.Content.ReadAsStreamAsync();
        //    var store = await JsonSerializer.DeserializeAsync<IEnumerable<TranshareModel>>(data);
        //    return store;
        //}
    }
}