using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.ViewModels {
	public class PowerBIEmbeddedViewModel {
		public string ReportID { get; set; }

		public PowerBIEmbeddedViewModel() { }
		public PowerBIEmbeddedViewModel(string reportID) => ReportID = reportID;
	}
}
