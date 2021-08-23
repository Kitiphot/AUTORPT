using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Quartz;
using SCG.ARS.BOI.WEB.Repositories;
using SCG.ARS.BOI.WEB.Services;

namespace SCG.ARS.BOI.WEB.Jobs
{
    [DisallowConcurrentExecution]
    public class LineMessageJob : IJob
    {
        private readonly ILogger<LineMessageJob> _logger;
        private readonly ILineMessageService _lineMessageService;

        private readonly HttpContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;
        private IReportRepository _report;
        private IFunctionTemplateRepository _template;
        public LineMessageJob(ILogger<LineMessageJob> logger,
            IHttpContextAccessor httpContextAccessor,
            IHostingEnvironment hostingEnvironment,
            IReportRepository report,
            IFunctionTemplateRepository template,
            ILineMessageService lineMessageService)
        {
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
            _context = httpContextAccessor.HttpContext;
            _report = report;
            _template = template;
            _lineMessageService = lineMessageService;
        }

        public Task Execute(IJobExecutionContext context)
        {
            _logger.LogInformation("Line Message Job Execute!");
            Debug.WriteLine($"{DateTime.Now}: Line Message Job");

            string message = $@"ทดสอบรายงาน Summary Performance วันที่ {DateTime.Now.AddHours(7):dd/MM/yyyy HH:mm)}
            ";
            var data = _report.GetSummaryPerformance();
            var groups = data.GroupBy(g => g.fleet);
            foreach (var group in groups)
            {
                var filter = data.Where(w => w.fleet == group.Key);
                foreach (var line in filter)
                {
                    message += $@"
Fleet {line.fleet_truck}
Order คงค้างเมื่อวาน{line.yesterday_order_pending}
Order วันนี้         {line.today_order}
รถได้งาน             {line.order_accept}
รถเหลือ/ขาด       {line.remain_truck}
Order ค้าง          {line.today_order_pending}
------------------------";
                };
                //Debug.WriteLine(message);
                _lineMessageService.SendNotify(message);
                message = string.Empty;
            }



            //             _lineMessageService.SendNotify($@"
            // Order งานพื้นเรียบ 6 เที่ยว
            // อุดม P.2 A.1
            // นนทรี P.0 A.0
            // วังศาลา P.6 A.4
            // พีแอลบี P.1 A.1
            // ---------------------------------------
            // Order งาน สระบุรี ม้วน
            // งานม้วน (TCSB) 4 เที่ยว
            // ลานเหล็ก 1 คัน รับเศษ TCSB
            // วังศาลา 1 คัน รับเศษ TCSB
            // ส.สุทธิอาจ 1 Skate รับปูน 
            // อุดม พื้นเรียบ  1  รับปูน 
            // ----------------------------------------
            // Order งาน สงขลา ม้วน
            // งานม้วน (TCSK) 3 เที่ยว
            // ลานเหล็ก 3 Skate
            // -----------------------------------------
            // Order งานยิปซั่ม สระบุรี 6 เที่ยว

            // เอกรัฐ รถยิปซัม 6 คัน (ลงสินค้าวันที่ 12.6.2563)
            // ----------------------------------------
            // Order งาน TCCB 6 เที่ยว
            // ดารัช P.2 A.4
            // -ประเภทรถ Skate 1 รับเศษ TCCB
            // -ประเภทรถ SC 3
            // เอกจันทิมา 1 Skate  
            // วังศาลา  1 Skate

            // ---------------------------------------
            // Order งาน TCRY 4 เที่ยว
            // ดารัช P.3 A.1 
            // -ประเภทรถ Skate 0 คัน
            // -ประเภทรถ SC 1 คัน
            // ศิรากิจ 1 Skate รับเศษTCRY ลงไทยเคนกบิน
            // วอนเพียร 1 Skate 
            // วังศาลา   1 Skate");
            Debug.WriteLine(message);
            return Task.CompletedTask;
        }
    }
}