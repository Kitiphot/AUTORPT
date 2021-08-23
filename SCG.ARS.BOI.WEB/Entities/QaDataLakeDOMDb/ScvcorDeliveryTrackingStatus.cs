using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class ScvcorDeliveryTrackingStatus
    {
        public string DeliveryNumber { get; set; }
        public string LoadId { get; set; }
        public int? LoadLeg { get; set; }
        public int? LastTrackingStatus { get; set; }
        public Instant? ActualOpen { get; set; }
        public Instant? ActualPlan { get; set; }
        public Instant? ActualTender { get; set; }
        public Instant? ActualTenderAccept { get; set; }
        public Instant? ActualInOrigin { get; set; }
        public Instant? ActualGiDate { get; set; }
        public Instant? ActualInTransit { get; set; }
        public Instant? ActualOutOrigin { get; set; }
        public Instant? ActualInDestination { get; set; }
        public Instant? ActualDeliveryDate { get; set; }
        public Instant? ActualOutDestination { get; set; }
        public Instant? ActualDocumentReturn { get; set; }
        public Instant? ActualCdasDpboothDate { get; set; }
        public Instant? ActualCdasInboundDate { get; set; }
        public Instant? ActualCdasTareDate { get; set; }
        public Instant? ActualCdasBayinDate { get; set; }
        public Instant? ActualCdasBayoutDate { get; set; }
        public Instant? ActualCdasGiDate { get; set; }
        public decimal? InfoCdasTareWeight { get; set; }
        public decimal? InfoCdasGiWeight { get; set; }
        public string InfoCdasBayNo { get; set; }
        public string InfoCdasSealno { get; set; }
        public Instant? InfoDnAttachDate { get; set; }
        public Instant? InfoLpcDocumentDate { get; set; }
        public Instant? InfoBillingDate { get; set; }
        public Instant? InfoPaymentDate { get; set; }
        public Instant? InfoInvoicePaymentDate { get; set; }
        public decimal? InfoGiWeight { get; set; }
        public Instant? InfoGrDate { get; set; }
        public decimal? InfoGrWeight { get; set; }
        public Instant? InfoPlanDeliveryDate { get; set; }
        public string InfoPlanDeliveryExtendMsg { get; set; }
        public Instant? InfoPlanDeliveryWarnDate { get; set; }
        public string UserCreateName { get; set; }
        public Instant? UserCreateDate { get; set; }
        public string UserUpdateName { get; set; }
        public Instant? UserUpdateDate { get; set; }
        public byte[] Rowversion { get; set; }
        public Instant? InfoPodAbcaseDate { get; set; }
        public Instant? InfoPodAttachEdpDate { get; set; }
        public Instant? InfoPodAttachImgDate { get; set; }
        public Instant? InfoPodTrackLocDate { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
