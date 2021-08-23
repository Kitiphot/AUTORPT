using System;
using System.Collections.Generic;

namespace SCG.ARS.BOI.WEB.Entities.QuartzDb
{
    public partial class QrtzSchedulerState
    {
        public string SchedName { get; set; }
        public string InstanceName { get; set; }
        public long LastCheckinTime { get; set; }
        public long CheckinInterval { get; set; }
    }
}
