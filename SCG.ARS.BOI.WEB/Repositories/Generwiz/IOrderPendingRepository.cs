using SCG.ARS.BOI.WEB.Models.Generwiz;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using SCG.ARS.BOI.WEB.Configuration;
using SCG.ARS.BOI.WEB.Entities.MasterDb;
using SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb;
using SCG.ARS.BOI.WEB.Entities.QaDataLakePKGDb;
using SCG.ARS.BOI.WEB.Entities.QaDataLakeWHDb;
using Npgsql;
using Microsoft.Extensions.Options;
using NLog;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace SCG.ARS.BOI.WEB.GENZ.Repositories
{
    public interface IOrderPendingRepository
    {
		List<OrderPendingModel> GetWaitingList(string trucktype, string shipto, string origin);
		List<OrderPendingDetailModel> GetDetailBookingList(string Businessgroup, string Customergroup, string Productgroup, string Status, string OriginRegions, string DestinationRegions, string TruckTypes);
		List<OrderPendingDetailModel> GetDetailWaitingList(string Businessgroup, string Customergroup, string Productgroup, string Status, string OriginRegions, string DestinationRegions, string TruckTypes);
		//List<OrderPendingModel> GetBookingList();

	}

    public class OrderPendingRepository : BaseContext, IOrderPendingRepository
    {
		static Logger logger = LogManager.GetCurrentClassLogger();
		private ConnectionStrings _connections;
		private string _tempPath;
		private string connectionsString;
		IConfiguration _configure;
		public OrderPendingRepository(IConfiguration configuration,
			IOptions<ConnectionStrings> connections)
		{
			_connections = connections.Value;
			connectionsString = configuration.GetConnectionString("PDLakeConnection").ToString();
		}
        internal IDbConnection PDLakeConnection
        {
            get
            {
                return new NpgsqlConnection(connectionsString);
            }
        }

        public List<OrderPendingModel> GetWaitingList(string trucktype, string shipto, string origin)
        {

			List<string> smList = new List<string>();
			string[] lines = shipto.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
			foreach (string line in lines)
			{
				string[] smNos = line.Split("|");
				smList.AddRange(smNos);
			}
			string whereshipto = string.Join("','", smList.ToArray());

			List<string> bkList = new List<string>();
			string[] bklines = origin.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
			foreach (string bkline in bklines)
			{
				string[] smNos = bkline.Split("|");
				bkList.AddRange(smNos);
			}
			string whereorigin = string.Join("','", bkList.ToArray());

			List<string> ttList = new List<string>();
			string[] ttlines = trucktype.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
			foreach (string ttline in ttlines)
			{
				string[] smNos = ttline.Split(",");
				ttList.AddRange(smNos);
			}
			string wheretrucktype = string.Join("','", ttList.ToArray());


			List<OrderPendingModel> orderList = new List<OrderPendingModel>();
            try
            {
                using (IDbConnection dbConnection = PDLakeConnection)
                {
                    dbConnection.Open();
                    var data = dbConnection.Query<OrderPendingModel>($@"
                        SELECT mdg.businessgroup, mdg.customergroup, mdg.productgroup, bkl.toltalrequestedbooking, bkl.toltalordersamedaybooking,
							   bkl.toltaltender, bkl.toltallasttender, bkl.toltalorderleadtimebooking, bkl.toltalrank,
							   wtl.toltalcreatewaiting, wtl.toltalrequestedwaiting, wtl.toltaltenderwaiting
						FROM dom.tms_master_default_gruop mdg
						LEFT JOIN 
							(
								SELECT bk.businessgroup, bk.customergroup, bk.productgroup, 
										SUM(bk.requestedorderdate) AS toltalrequestedbooking, SUM(bk.OrderSameDay) AS toltalordersamedaybooking,
										SUM(bk.tenderdate) AS toltaltender, SUM(bk.lasttenderdate) AS toltallasttender, 
										SUM(bk.OnLeadTime) AS toltalorderleadtimebooking, 0 AS toltalrank
										FROM
										(
											SELECT case when osi.materialfreightgroup like 'A%' THEN 'Cement' 
														when osi.materialfreightgroup SIMILAR TO '(B|C)%' THEN 'Building Mat'
														when osi.materialfreightgroup like 'G%' THEN 'DURA' END businessgroup,
												   tmm.mappinggroup AS productgroup,
												   case when osi.materialfreightgroup like 'A%' then COALESCE(cst.mappinggroup, 'Agent')
															when osi.materialfreightgroup SIMILAR TO '(B|C)%' and oso.ponumber like 'VMI%' then 'VMI' 					 				
															when osi.materialfreightgroup like 'G%' then COALESCE(cus.mappinggroup, 'Agent')
															else 'Agent' end customergroup, obp.vehicletypecode,
												   oso.ponumber, oso.customercode, oso.sapshippingpoint, oso.sapshiptocode, oso.shipmentloadid,
												   stl.actual_tender, oso.requesteddate, oso.orderdate, osi.materialfreightgroup,
												   mst.region as shiptoregion, msp.region as originregion, mdr.leadtime,
												   case when stl.actual_tender is null and (CAST(MAX(oso.requesteddate) AS date) - CAST(MIN(CURRENT_DATE) AS date)) 
		   													  >= 0 and (CAST(MAX(oso.requesteddate) AS date) - CAST(MIN(CURRENT_DATE) AS date)) 
		   													  <= mdr.leadtime then 1 else 0 end OnLeadTime,
												   case when stl.actual_tender is null and cast(oso.requesteddate as timestamp) 
		   												between CURRENT_DATE - 7 and CURRENT_DATE then 1 else 0 end requestedorderdate,
												   case when stl.actual_tender is null and cast(oso.requesteddate as timestamp) = cast(oso.orderdate as timestamp) then 1 else 0 end OrderSameDay,
												   case when stl.actual_tender is not null and cast(TO_CHAR(stl.actual_tender, 'YYYY-MM-DD') as timestamp) = CURRENT_DATE
		   												then 1 else 0 end tenderdate,
												   case when stl.actual_tender is not null and cast(TO_CHAR(stl.actual_tender, 'YYYY-MM-DD') as timestamp)
														between CURRENT_DATE - 3 and CURRENT_DATE - 1 then 1 else 0 end lasttenderdate
											FROM dom.omsord_delivery_sap_header oso
											INNER JOIN dom.omsord_delivery_sap_item osi ON osi.dnnumber = oso.dnnumber
											INNER JOIN dom.omsord_master_location mst ON mst.locationcode = oso.destinationcode
											INNER JOIN dom.omsord_master_location msp ON msp.locationcode = oso.origincode
											LEFT JOIN dom.scvmvc_tms_load_tracking stl ON stl.load_id = oso.shipmentloadid
											LEFT JOIN dom.tms_master_mapping tmm ON (oso.sapshippingpoint = tmm.mappingcode or osi.materialfreightgroup = tmm.mappingcode)
												and tmm.mappingtype = 'origin'
											LEFT JOIN dom.tms_master_mapping cst ON oso.sapshiptocode = cst.mappingcode and cst.mappingtype = 'shipto'
											LEFT JOIN dom.tms_master_mapping cus ON oso.customercode = cus.mappingcode and cus.mappingtype = 'soldto'
											LEFT JOIN dom.omscbm_order_schedule_split_queue ssq ON lpad(substring(oso.sonumber, 2, length(oso.sonumber)), 10, '0') = ssq.orderno
											LEFT JOIN dom.omscbm_book_plan obp ON obp.booknumber = ssq.booknumber
											LEFT JOIN dom.tms_master_default_region mdr ON mdr.regionfrom = cast(msp.region as varchar) and mdr.regionto = cast(mst.region as varchar)	
											WHERE cast(oso.requesteddate as timestamp) > CURRENT_DATE - 7 and osi.materialfreightgroup SIMILAR TO '(A|B|C|G)%'
												and osi.materialfreightgroup not SIMILAR TO '(C06|C07|C08)%'
												--and obp.vehicletypecode IN ('{wheretrucktype}')
												and mst.region IN ('{whereshipto}') and msp.region IN ('{whereorigin}')
											GROUP BY osi.materialfreightgroup, tmm.mappinggroup, obp.vehicletypecode, oso.ponumber, 
													 oso.customercode, oso.sapshippingpoint, oso.sapshiptocode, oso.shipmentloadid,
													 stl.actual_tender, oso.requesteddate, oso.orderdate, osi.materialfreightgroup,
													 mst.region, msp.region, mdr.leadtime, cst.mappinggroup, cus.mappinggroup
										ORDER BY oso.requesteddate
										) bk 
										where bk.productgroup is not null
										GROUP BY bk.businessgroup, bk.customergroup, bk.productgroup
							) bkl ON bkl.businessgroup = mdg.businessgroup and bkl.customergroup = mdg.customergroup and bkl.productgroup = mdg.productgroup
						LEFT JOIN 
							(
								SELECT businessgroup, customergroup, productgroup, 
								SUM(wt.createorderdate) AS toltalcreatewaiting, SUM(wt.requesteddate) AS toltalrequestedwaiting,
								0 AS toltaltenderwaiting
									FROM
									(
										SELECT obp.waitingflag, case when osi.matfreightgroup like 'A%' THEN 'Cement' 
												when osi.matfreightgroup SIMILAR TO '(B|C)%' THEN 'Building Mat'
												when osi.matfreightgroup like 'G%' THEN 'DURA' END businessgroup,
												tmm.mappinggroup AS productgroup,
												case when osi.matfreightgroup like 'A%' then COALESCE(cst.mappinggroup, 'Agent')
													when osi.matfreightgroup SIMILAR TO '(B|C)%' and oso.pono like 'VMI%' then 'VMI' 					 				
													when osi.matfreightgroup like 'G%' then COALESCE(cus.mappinggroup, 'Agent')
													else 'Agent' end customergroup,
											   oso.orderno, oso.incoterm1, oso.incoterm2, oso.pono, oso.soldtocode, oso.soldtoname,  
											   oso.shiptocode, oso.shiptoname, oso.orderreqdeliverydate, 
											   oso.ordercreatedate, mst.region as shiptoregion, msp.region as originregion,
											   case when cast(oso.ordercreatedate as timestamp) = CURRENT_DATE - 14 then 1 else 0 end createorderdate,
											   case when cast(ssq.requesteddate as timestamp) between CURRENT_DATE - 13 and CURRENT_DATE + 1 then 1 else 0 end requesteddate,
											   osi.shippingpoint, osi.shippingpointdesc, osi.shippingcondition,
											   osi.materialcode, osi.materialdesc, osi.matfreightgroup, osi.matfreightgroupdesc
										FROM dom.omsord_sap_order oso
										INNER JOIN dom.omsord_sap_order_item osi ON osi.orderno = oso.orderno
										LEFT JOIN dom.tms_master_mapping tmm ON (osi.shippingpoint = tmm.mappingcode or osi.matfreightgroup = tmm.mappingcode)
										and tmm.mappingtype = 'origin'
										LEFT JOIN dom.tms_master_mapping cst ON oso.shiptocode = cst.mappingcode and cst.mappingtype = 'shipto'
										LEFT JOIN dom.tms_master_mapping cus ON oso.soldtocode = cus.mappingcode and cus.mappingtype = 'soldto'
										INNER JOIN dom.omscbm_order_schedule_split_queue ssq ON lpad(substring(oso.orderno, 2, length(oso.orderno)), 10, '0') = ssq.orderno
										INNER JOIN dom.omscbm_book_plan obp ON obp.booknumber = ssq.booknumber and obp.waitingflag = true
										INNER JOIN dom.omsord_master_location mst ON mst.locationcode = oso.omsdestlocationcode
										INNER JOIN dom.omsord_master_location msp ON msp.locationcode = osi.omsoriginlocationcode
										WHERE cast(oso.ordercreatedate as timestamp) > CURRENT_DATE - 20 and 
											osi.matfreightgroup SIMILAR TO '(A|B|C|G)%' and osi.matfreightgroup not SIMILAR TO '(C06|C07|C08)%'
											and ssq.booknumber is not null --and obp.waitingflag = true
											--and obp.vehicletypecode IN ('{wheretrucktype}') 
											and mst.region IN ('{whereshipto}') and msp.region IN ('{whereorigin}')
										ORDER BY oso.ordercreatedate	
									) wt 
									where wt.productgroup is not null
									GROUP BY wt.businessgroup, wt.customergroup, wt.productgroup
							) wtl ON wtl.businessgroup = mdg.businessgroup and wtl.customergroup = mdg.customergroup and wtl.productgroup = mdg.productgroup
						order by mdg.businessgroup ");
                    orderList = data.ToList();
                    return orderList;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }


		public List<OrderPendingDetailModel> GetDetailBookingList(string Businessgroup, string Customergroup, string Productgroup, string Status, string OriginRegions, string DestinationRegions, string TruckTypes)
		{
			string where = string.Empty;
            if (Businessgroup == "Building Mat")
            {
				where += " osi.materialfreightgroup SIMILAR TO '(B|C)%' and osi.materialfreightgroup not SIMILAR TO '(C06|C07|C08)%'";
                if (Customergroup == "VMI")
                {
					where += " and oso.ponumber like 'VMI%'";
				}
                else
                {
					where += " and oso.ponumber not like 'VMI%'";
				}

			}
			else if (Businessgroup == "Cement")
			{
				where += " osi.materialfreightgroup LIKE 'A%'";

				if (Customergroup == "Distribution")
				{
					where += " and cst.mappinggroup is not null ";
				}
				else
				{
					where += " and cst.mappinggroup is null ";
				}

			}
			else if (Businessgroup == "DURA")
			{
				where += " osi.materialfreightgroup LIKE 'G%'";

				if (Customergroup == "Modern Trade")
				{
					where += " and cus.mappinggroup is not null";
				}
				else
				{
					where += " and cus.mappinggroup is null";
				}

				if (Productgroup == "Board Wood")
				{
					where += " and osi.materialfreightgroup in ('G0125','G0129','G0126')";
				}
				else if (Productgroup == "Fiber Cement")
				{
					where += " and osi.materialfreightgroup = 'G0121'";
				}

			}

			if (Productgroup == "Block")
			{
				where += " and tmm.mappinggroup = 'Block'";
			}
			else if (Productgroup == "Cement")
			{
				where += " and tmm.mappinggroup = 'Cement'";
			}
			else if (Productgroup == "Ceramic")
			{
				where += " and tmm.mappinggroup = 'Ceramic'";
			}
			else if (Productgroup == "Gypsum")
			{
				where += " and tmm.mappinggroup = 'Gypsum'";
			}
			else if (Productgroup == "Monier")
			{
				where += " and tmm.mappinggroup = 'Monier'";
			}
			else if (Productgroup == "Q-Con")
			{
				where += " and tmm.mappinggroup = 'Q-Con'";
			}
			else if (Productgroup == "SFCG")
			{
				where += " and tmm.mappinggroup = 'SFCG'";
			}


			if (Status == "lasttender")
			{
				where += " and stl.actual_tender is not null and cast(TO_CHAR(stl.actual_tender, 'YYYY-MM-DD') as timestamp) between CURRENT_DATE -3 " +
						"and CURRENT_DATE";
			}
			else if (Status == "bookingtoday7")
			{
				where += " and stl.actual_tender is null and cast(oso.requesteddate as timestamp) between CURRENT_DATE -7 and CURRENT_DATE ";
			}
			else if (Status == "bookingordersameday")
			{
				where += " and stl.actual_tender is null and cast(oso.requesteddate as timestamp) between CURRENT_DATE -7 and CURRENT_DATE " +
						"and cast(oso.requesteddate as timestamp) = cast(oso.orderdate as timestamp)";
			}
			else if (Status == "bookingorderleadtime")
			{
				where += " and stl.actual_tender is null and cast(oso.requesteddate as timestamp) between CURRENT_DATE -7 and CURRENT_DATE " +
						"and (CAST(oso.requesteddate AS date) - CAST(CURRENT_DATE AS date)) between 0 and mdr.leadtime";
			}
			else if (Status == "bookingtender")
			{
				where += " and stl.actual_tender is not null and cast(TO_CHAR(stl.actual_tender, 'YYYY-MM-DD') as timestamp) = CURRENT_DATE";
			}

			//origin
			List<string> originList = new List<string>();
			string[] originlines = OriginRegions.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
			foreach (string line in originlines)
			{
				string[] smNos = line.Split(",");
				originList.AddRange(smNos);
			}
			string whereorigin = string.Join("','", originList.ToArray());

			//shipto
			List<string> desList = new List<string>();
			string[] deslines = DestinationRegions.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
			foreach (string line in deslines)
			{
				string[] smNos = line.Split(",");
				desList.AddRange(smNos);
			}
			string whereshipto = string.Join("','", desList.ToArray());

			//trucktype
			List<string> trucktypeList = new List<string>();
			string[] trucktypelines = DestinationRegions.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
			foreach (string line in trucktypelines)
			{
				string[] smNos = line.Split(",");
				trucktypeList.AddRange(smNos);
			}
			string wheretrucktype = string.Join("','", trucktypeList.ToArray());

			List<OrderPendingDetailModel> orderList = new List<OrderPendingDetailModel>();
			try
			{
				using (IDbConnection dbConnection = PDLakeConnection)
				{
					dbConnection.Open();
					var data = dbConnection.Query<OrderPendingDetailModel>($@"
                        SELECT DISTINCT oso.ponumber, oso.customercode, oso.customername, oso.sapshippingpoint, oso.sapshiptocode, oso.destinationname, 
							   oso.destinationcode, oso.shiptoregioncode, oso.shiptoregionname, osi.materialcode, osi.materialname,
							   oso.shiptoaddress, oso.shiptocity, osi.refdnnumber AS dnnumber, oso.shipmentloadid, oso.orderdoctype, oso.origincode, oso.originname,
							   stl.actual_tender, oso.requesteddate, oso.orderdate, osi.materialfreightgroup, osi.materialfreightdescription,  
							   oso.sonumber, osi.shippingcondition, osi.shippingconditiondescription, oso.plannername, mst.provincecode, mst.region as shiptoregioncode, msp.region as originregion,
							   osi.totalnetweight, ssq.orderline, oso.vehicletypeid AS vehicletypecode, mvt.vehicletypename AS vehicletypename, oso.shipmentmemo,
							   tll.carrier_code AS carriercode, tll.carrier_name AS carriername, ssq.status, obp.booknumber, mds.name AS dnnanme, tll.load_status AS loadstatus
						FROM dom.omsord_delivery_sap_header oso
						INNER JOIN dom.omsord_delivery_sap_item osi ON osi.dnnumber = oso.dnnumber
						INNER JOIN dom.omsord_master_dn_status mds ON mds.code = oso.statuscode
						LEFT JOIN dom.scvmvc_tms_load_leg tll ON tll.load_id = oso.shipmentloadid 
						LEFT JOIN dom.scvmvc_tms_load_tracking stl ON stl.load_id = oso.shipmentloadid	
						LEFT JOIN dom.omscbm_master_vehicle_type mvt ON mvt.vehicletypecode = oso.vehicletypeid	
						LEFT JOIN dom.poddat_mstcarrier mcr ON mcr.carriercode = oso.carriercode  
						INNER JOIN dom.omsord_master_location mst ON mst.locationcode = oso.destinationcode
						INNER JOIN dom.omsord_master_location msp ON msp.locationcode = oso.origincode
						--LEFT JOIN dom.metadata_master_province mmp ON mmp.regioncodem = mst.provincecode
						LEFT JOIN dom.tms_master_default_region mdr ON mdr.regionfrom = cast(msp.region as varchar) and mdr.regionto = cast(mst.region as varchar)
						LEFT JOIN dom.tms_master_mapping tmm ON (oso.sapshippingpoint = tmm.mappingcode or osi.materialfreightgroup = tmm.mappingcode)
							and tmm.mappingtype = 'origin'
						LEFT JOIN dom.tms_master_mapping cst ON oso.sapshiptocode = cst.mappingcode and cst.mappingtype = 'shipto'
						LEFT JOIN dom.tms_master_mapping cus ON oso.customercode = cus.mappingcode and cus.mappingtype = 'soldto'
						LEFT JOIN dom.omscbm_order_schedule_split_queue ssq ON lpad(substring(oso.sonumber, 2, length(oso.sonumber)), 10, '0') = ssq.orderno
						LEFT JOIN dom.omscbm_book_plan obp ON obp.booknumber = ssq.booknumber
						WHERE mst.region IN ('{whereshipto}') and msp.region IN ('{whereorigin}') AND {where }
						      --and obp.vehicletypecode IN ('{wheretrucktype}') 
						ORDER BY oso.requesteddate ");
					orderList = data.ToList();
					return orderList;
				}
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				return null;
			}
		}


		public List<OrderPendingDetailModel> GetDetailWaitingList(string Businessgroup, string Customergroup, string Productgroup, string Status, string OriginRegions, string DestinationRegions, string TruckTypes)
		{
			string where = string.Empty;
			if (Businessgroup == "Building Mat")
			{
				where += " osi.matfreightgroup SIMILAR TO '(B|C)%' and osi.materialfreightgroup not SIMILAR TO '(C06|C07|C08)%'";
				if (Customergroup == "VMI")
				{
					where += " and oso.ponumber like 'VMI%'";
				}
				else
				{
					where += " and oso.ponumber not like 'VMI%'";
				}

			}
			else if (Businessgroup == "Cement")
			{
				where += " osi.matfreightgroup LIKE 'A%'";

				if (Customergroup == "Distribution")
				{
					where += " and cst.mappinggroup is not null ";
				}
				else
				{
					where += " and cst.mappinggroup is null ";
				}

			}
			else if (Businessgroup == "DURA")
			{
				where += " osi.matfreightgroup LIKE 'G%'";

				if (Customergroup == "Modern Trade")
				{
					where += " and cus.mappinggroup is not null";
				}
				else
				{
					where += " and cus.mappinggroup is null";
				}

				if (Productgroup == "Board Wood")
				{
					where += " and osi.matfreightgroup in ('G0125','G0129','G0126')";
				}
				else if (Productgroup == "Fiber Cement")
				{
					where += " and osi.matfreightgroup = 'G0121'";
				}

			}

			if (Productgroup == "Block")
			{
				where += " and tmm.mappinggroup = 'Block'";
			}
			else if (Productgroup == "Cement")
			{
				where += " and tmm.mappinggroup = 'Cement'";
			}
			else if (Productgroup == "Ceramic")
			{
				where += " and tmm.mappinggroup = 'Ceramic'";
			}
			else if (Productgroup == "Gypsum")
			{
				where += " and tmm.mappinggroup = 'Gypsum'";
			}
			else if (Productgroup == "Monier")
			{
				where += " and tmm.mappinggroup = 'Monier'";
			}
			else if (Productgroup == "Q-Con")
			{
				where += " and tmm.mappinggroup = 'Q-Con'";
			}
			else if (Productgroup == "SFCG")
			{
				where += " and tmm.mappinggroup = 'SFCG'";
			}


			if (Status == "waitinglisttoday14")
			{
				where += " and cast(oso.ordercreatedate as timestamp) = CURRENT_DATE - 14";
			}
			else if (Status == "waitinglisttoday13")
			{
				where += " and cast(oso.ordercreatedate as timestamp) >= CURRENT_DATE - 20" +
					" and cast(ssq.requesteddate as timestamp) between CURRENT_DATE - 13 and CURRENT_DATE + 1 ";
			}

			//origin
			List<string> originList = new List<string>();
			string[] originlines = OriginRegions.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
			foreach (string line in originlines)
			{
				string[] smNos = line.Split(",");
				originList.AddRange(smNos);
			}
			string whereorigin = string.Join("','", originList.ToArray());

			//shipto
			List<string> desList = new List<string>();
			string[] deslines = DestinationRegions.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
			foreach (string line in deslines)
			{
				string[] smNos = line.Split(",");
				desList.AddRange(smNos);
			}
			string whereshipto = string.Join("','", desList.ToArray());

			//trucktype
			List<string> trucktypeList = new List<string>();
			string[] trucktypelines = DestinationRegions.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
			foreach (string line in trucktypelines)
			{
				string[] smNos = line.Split(",");
				trucktypeList.AddRange(smNos);
			}
			string wheretrucktype = string.Join("','", trucktypeList.ToArray());

			List<OrderPendingDetailModel> orderList = new List<OrderPendingDetailModel>();
			try
			{
				using (IDbConnection dbConnection = PDLakeConnection)
				{
					dbConnection.Open();
					var data = dbConnection.Query<OrderPendingDetailModel>($@"
                        SELECT ssq.requesteddate AS requesteddate, ssq.booknumber, osi.grossweight AS totalnetweight,
							   oso.shiptodistrict AS shiptoaddress, oso.shiptocity, obp.vehicletypecode, obp.vehicletypename,
							   oso.orderno AS sonumber, oso.incoterm1, oso.incoterm2, oso.pono AS ponumber, mst.provincecode,
							   oso.soldtocode AS customercode, oso.soldtoname AS customername, '' AS plannername,
							   oso.shiptocode AS destinationcode, oso.shiptoname AS destinationname, oso.orderreqdeliverydate, 
							   oso.ordercreatedate AS orderdate, mst.region as shiptoregioncode, msp.region as originregion,
							   osi.shippingpoint AS origincode, osi.shippingpointdesc AS originname, osi.shippingcondition, osi.shippingconditiondesc AS shippingconditiondescription,
							   osi.materialcode, osi.materialdesc AS materialname, osi.matfreightgroup AS materialfreightgroup, osi.matfreightgroupdesc
						FROM dom.omsord_sap_order oso
						INNER JOIN dom.omsord_sap_order_item osi ON osi.orderno = oso.orderno
						LEFT JOIN dom.tms_master_mapping tmm ON (osi.shippingpoint = tmm.mappingcode or osi.matfreightgroup = tmm.mappingcode)
						and tmm.mappingtype = 'origin'
						LEFT JOIN dom.tms_master_mapping cst ON oso.shiptocode = cst.mappingcode and cst.mappingtype = 'shipto'
						LEFT JOIN dom.tms_master_mapping cus ON oso.soldtocode = cus.mappingcode and cus.mappingtype = 'soldto'
						INNER JOIN dom.omscbm_order_schedule_split_queue ssq ON lpad(substring(oso.orderno, 2, length(oso.orderno)), 10, '0') = ssq.orderno
						INNER JOIN dom.omscbm_book_plan obp ON obp.booknumber = ssq.booknumber and obp.waitingflag = true
						INNER JOIN dom.omsord_master_location mst ON mst.locationcode = oso.omsdestlocationcode
						INNER JOIN dom.omsord_master_location msp ON msp.locationcode = osi.omsoriginlocationcode
						WHERE mst.region IN ('{whereshipto}') and msp.region IN ('{whereorigin}') AND {where }
						      --and obp.vehicletypecode IN ('{wheretrucktype}') 
						ORDER BY oso.ordercreatedate ");
					orderList = data.ToList();
					return orderList;
				}
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				return null;
			}
		}

	}
}
