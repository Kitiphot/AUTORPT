using Quartzmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Models.Master
{
    public class TemplateTrigger : TriggerListItem
    {
        public int? template_trigger_id { get; set; }
        public string template_sched_name { get; set; }
        public string template_trigger_name { get; set; }
        public string template_trigger_group { get; set; }
        public string template_from { get; set; }
        public string template_to { get; set; }
        public string template_cc { get; set; }
        public string template_bcc { get; set; }
        public string template_subject { get; set; }
        public string template_body { get; set; }
        public int tab_number { get; set; }
        public int daily_type { get; set; }
        public int minutes { get; set; }
        public int hours { get; set; }
        public string daily_time { get; set; }
        public string weekly_time { get; set; }
        public string monthly_time { get; set; }
        public string[] weekly { get; set; }
        public int[] selected_dates { get; set; }
        public bool end_of_month { get; set; }
        public string sched_name { get; set; }
        public string trigger_name { get; set; }
        public string trigger_group { get; set; }
        public string job_name { get; set; }
        public string job_group { get; set; }
        public string description { get; set; }
        public long? next_fire_time { get; set; }
        public long? prev_fire_time { get; set; }
        public int? priority { get; set; }
        public string trigger_state { get; set; }
        public string trigger_type { get; set; }
        public long start_time { get; set; }
        public long? end_time { get; set; }
        public string calendar_name { get; set; }
        public short? misfire_instr { get; set; }
        public byte[] job_data { get; set; }
    }
}
