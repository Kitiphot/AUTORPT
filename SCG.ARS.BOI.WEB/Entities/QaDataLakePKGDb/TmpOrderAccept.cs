using System;
using System.Collections.Generic;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakePKGDb
{
    public partial class TmpOrderAccept
    {
        public string Shipment { get; set; }
        public string Shipment2 { get; set; }
        public string DPNo { get; set; }
        public string สถานทขนสนคา { get; set; }
        public string ลกคา { get; set; }
        public string สถานทสง { get; set; }
        public string ประเภทรถ { get; set; }
        public string ผขนสง { get; set; }
        public string Fleet { get; set; }
        public string SubTruckType { get; set; }
        public string Carrier { get; set; }
        public string TruckLicense { get; set; }
        public float? Weight { get; set; }
        public string กำหนดสง { get; set; }
        public string จองควสถานะ1 { get; set; }
        public string จายงานสถานะ1 { get; set; }
        public string ตอบรบงานสถานะ2 { get; set; }
        public string เขาโรงงานสถานะ21 { get; set; }
        public string รอขนสนคาสถานะ3 { get; set; }
        public string ขนสนคาเสรจสถานะ4 { get; set; }
        public string ออกจากโรงงานสถานะ41 { get; set; }
        public string รอลงสนคาสถานะ5 { get; set; }
        public string เดนทางกลบสถานะ6 { get; set; }
        public string ถงจดรบbhสถานะ7 { get; set; }
        public string ออกจากbhสถานะ71 { get; set; }
        public string รอลงเศษสถานะ8 { get; set; }
        public string คนใบDpสถานะ9 { get; set; }
    }
}
