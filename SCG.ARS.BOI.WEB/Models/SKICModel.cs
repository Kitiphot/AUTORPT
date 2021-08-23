
namespace SCG.ARS.BOI.WEB.Models {
	public class SKICTruckRequestModel { 
		public int Month { get; set; }
		public int Year { get; set; }
		public string[] Fleet { get; set; }
		public string[] CarrierCode { get; set; }
		public string[] TruckType { get; set; }
		public string[] SubTruckType { get; set; }
	}
}
