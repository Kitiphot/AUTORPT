using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using NLog;
using SCG.ARS.BOI.WEB.Configuration;
using SCG.ARS.BOI.WEB.Entities.MasterDb;
using SCG.ARS.BOI.WEB.Entities.QaDataLakeWHDb;
using SCG.ARS.BOI.WEB.Models.Master;
using SCG.ARS.BOI.WEB.ViewModels;

namespace SCG.ARS.BOI.WEB.Repositories {
    public class FunctionTemplateRepository : IFunctionTemplateRepository {
        static Logger logger = LogManager.GetCurrentClassLogger ();
        private readonly IConfiguration _configuration;
        private readonly IServiceProvider _serviceProvider;
        private MasterContext _msContext;
        private QaWHContext _whContext;

        public FunctionTemplateRepository (IConfiguration configuration,
            IServiceProvider serviceProvider) {
            _configuration = configuration;
            _serviceProvider = serviceProvider;
        }
        public List<ColumnTemplate> GetColumnTemplate () {
            var list = new List<ColumnTemplate> ();
            // //template 1
            // list.AddRange (new List<ColumnTemplate> () {
            //     new ColumnTemplate {
            //         template_id = 1,
            //             column_name = "receiveddate"
            //     }, new ColumnTemplate {
            //         template_id = 1,
            //             column_name = "statusname"
            //     },
            //     new ColumnTemplate {
            //         template_id = 1,
            //             column_name = "po_invoice"
            //     },
            //     new ColumnTemplate {
            //         template_id = 1,
            //             column_name = "rc"
            //     },
            //     new ColumnTemplate {
            //         template_id = 1,
            //             column_name = "ean"
            //     },
            //     new ColumnTemplate {
            //         template_id = 1,
            //             column_name = "sku"
            //     },
            //     new ColumnTemplate {
            //         template_id = 1,
            //             column_name = "productdescription"
            //     },
            //     new ColumnTemplate {
            //         template_id = 1,
            //             column_name = "qty_in_ewm"
            //     },
            //     new ColumnTemplate {
            //         template_id = 1,
            //             column_name = "uom"
            //     },
            //     new ColumnTemplate {
            //         template_id = 1,
            //             column_name = "weight"
            //     },
            //     new ColumnTemplate {
            //         template_id = 1,
            //             column_name = "volume"
            //     },
            //     new ColumnTemplate {
            //         template_id = 1,
            //             column_name = "productgroupcode"
            //     },
            //     new ColumnTemplate {
            //         template_id = 1,
            //             column_name = "productgroupname"
            //     },
            //     new ColumnTemplate {
            //         template_id = 1,
            //             column_name = "suppliercode"
            //     },
            //     new ColumnTemplate {
            //         template_id = 1,
            //             column_name = "suppliername"
            //     },
            //     new ColumnTemplate {
            //         template_id = 1,
            //             column_name = "doctype"
            //     }
            // });
            // //template 2
            // list.AddRange (new List<ColumnTemplate> () {
            //     new ColumnTemplate {
            //         template_id = 2,
            //             column_name = "receiveddate"
            //     }, new ColumnTemplate {
            //         template_id = 2,
            //             column_name = "statusname"
            //     },
            //     new ColumnTemplate {
            //         template_id = 2,
            //             column_name = "po_invoice"
            //     },
            //     new ColumnTemplate {
            //         template_id = 2,
            //             column_name = "rc"
            //     },
            //     new ColumnTemplate {
            //         template_id = 2,
            //             column_name = "docrefno"
            //     },
            //     new ColumnTemplate {
            //         template_id = 2,
            //             column_name = "inbound"
            //     },
            //     new ColumnTemplate {
            //         template_id = 2,
            //             column_name = "ean"
            //     },
            //     new ColumnTemplate {
            //         template_id = 2,
            //             column_name = "sku"
            //     },
            //     new ColumnTemplate {
            //         template_id = 2,
            //             column_name = "productdescription"
            //     },
            //     new ColumnTemplate {
            //         template_id = 2,
            //             column_name = "entiled"
            //     },
            //     new ColumnTemplate {
            //         template_id = 2,
            //             column_name = "qty_in_ewm"
            //     },
            //     new ColumnTemplate {
            //         template_id = 2,
            //             column_name = "uom"
            //     },
            //     new ColumnTemplate {
            //         template_id = 2,
            //             column_name = "suppliercode"
            //     },
            //     new ColumnTemplate {
            //         template_id = 2,
            //             column_name = "suppliername"
            //     },
            //     new ColumnTemplate {
            //         template_id = 2,
            //             column_name = "doctype"
            //     }
            // });
            // //template 3
            // list.AddRange (new List<ColumnTemplate> () {
            //     new ColumnTemplate {
            //         template_id = 3,
            //             column_name = "receiveddate"
            //     }, new ColumnTemplate {
            //         template_id = 3,
            //             column_name = "statusname"
            //     },
            //     new ColumnTemplate {
            //         template_id = 3,
            //             column_name = "po_invoice"
            //     },
            //     new ColumnTemplate {
            //         template_id = 3,
            //             column_name = "rc"
            //     },
            //     new ColumnTemplate {
            //         template_id = 3,
            //             column_name = "docrefno"
            //     },
            //     new ColumnTemplate {
            //         template_id = 3,
            //             column_name = "inbound"
            //     },
            //     new ColumnTemplate {
            //         template_id = 3,
            //             column_name = "ean"
            //     },
            //     new ColumnTemplate {
            //         template_id = 3,
            //             column_name = "sku"
            //     },
            //     new ColumnTemplate {
            //         template_id = 3,
            //             column_name = "productdescription"
            //     },
            //     new ColumnTemplate {
            //         template_id = 3,
            //             column_name = "entiled"
            //     },
            //     new ColumnTemplate {
            //         template_id = 3,
            //             column_name = "qty_in_ewm"
            //     },
            //     new ColumnTemplate {
            //         template_id = 3,
            //             column_name = "uom"
            //     },
            //     new ColumnTemplate {
            //         template_id = 3,
            //             column_name = "weight"
            //     },
            //     new ColumnTemplate {
            //         template_id = 3,
            //             column_name = "volume"
            //     },
            //     new ColumnTemplate {
            //         template_id = 3,
            //             column_name = "productgroupcode"
            //     },
            //     new ColumnTemplate {
            //         template_id = 3,
            //             column_name = "productgroupname"
            //     },
            //     new ColumnTemplate {
            //         template_id = 3,
            //             column_name = "suppliercode"
            //     },
            //     new ColumnTemplate {
            //         template_id = 3,
            //             column_name = "suppliername"
            //     },
            //     new ColumnTemplate {
            //         template_id = 3,
            //             column_name = "doctype"
            //     }
            // });
            // //template 4
            // list.AddRange (new List<ColumnTemplate> () {
            //     new ColumnTemplate {
            //         template_id = 4,
            //             column_name = "pickingdate"
            //     }, new ColumnTemplate {
            //         template_id = 4,
            //             column_name = "statusname"
            //     },
            //     new ColumnTemplate {
            //         template_id = 4,
            //             column_name = "po_invoice"
            //     },
            //     new ColumnTemplate {
            //         template_id = 4,
            //             column_name = "dn"
            //     },
            //     new ColumnTemplate {
            //         template_id = 4,
            //             column_name = "ean"
            //     },
            //     new ColumnTemplate {
            //         template_id = 4,
            //             column_name = "sku"
            //     },
            //     new ColumnTemplate {
            //         template_id = 4,
            //             column_name = "productdescription"
            //     },
            //     new ColumnTemplate {
            //         template_id = 4,
            //             column_name = "qty_in_ewm"
            //     },
            //     new ColumnTemplate {
            //         template_id = 4,
            //             column_name = "uom"
            //     },
            //     new ColumnTemplate {
            //         template_id = 4,
            //             column_name = "weight"
            //     },
            //     new ColumnTemplate {
            //         template_id = 4,
            //             column_name = "volume"
            //     },
            //     new ColumnTemplate {
            //         template_id = 4,
            //             column_name = "productgroupcode"
            //     },
            //     new ColumnTemplate {
            //         template_id = 4,
            //             column_name = "productgroupname"
            //     },
            //     new ColumnTemplate {
            //         template_id = 4,
            //             column_name = "suppliercode"
            //     },
            //     new ColumnTemplate {
            //         template_id = 4,
            //             column_name = "suppliername"
            //     },
            //     new ColumnTemplate {
            //         template_id = 4,
            //             column_name = "doctype"
            //     }
            // });
            // //template 5
            // list.AddRange (new List<ColumnTemplate> () {
            //     new ColumnTemplate {
            //         template_id = 5,
            //             column_name = "sonumber"
            //     },
            //     new ColumnTemplate {
            //         template_id = 5,
            //             column_name = "pickingdate"
            //     },
            //     new ColumnTemplate {
            //         template_id = 5,
            //             column_name = "statusname"
            //     },
            //     new ColumnTemplate {
            //         template_id = 5,
            //             column_name = "shipmentnogroup"
            //     },
            //     new ColumnTemplate {
            //         template_id = 5,
            //             column_name = "customercode"
            //     },
            //     new ColumnTemplate {
            //         template_id = 5,
            //             column_name = "customername"
            //     },
            //     new ColumnTemplate {
            //         template_id = 5,
            //             column_name = "finaldestinationcode"
            //     },
            //     new ColumnTemplate {
            //         template_id = 5,
            //             column_name = "finaldestinationlongname"
            //     },
            //     new ColumnTemplate {
            //         template_id = 5,
            //             column_name = "productbarcode"
            //     },
            //     new ColumnTemplate {
            //         template_id = 5,
            //             column_name = "productdescription"
            //     },
            //     new ColumnTemplate {
            //         template_id = 5,
            //             column_name = "qty_in_ewm"
            //     },
            //     new ColumnTemplate {
            //         template_id = 5,
            //             column_name = "unit_code"
            //     },
            //     new ColumnTemplate {
            //         template_id = 5,
            //             column_name = "deliverydate"
            //     }
            // });
            // //template 6
            // list.AddRange (new List<ColumnTemplate> () {
            //     new ColumnTemplate {
            //         template_id = 6,
            //             column_name = "pickingdate"
            //     }, new ColumnTemplate {
            //         template_id = 6,
            //             column_name = "statusname"
            //     },
            //     new ColumnTemplate {
            //         template_id = 6,
            //             column_name = "po_invoice"
            //     },
            //     new ColumnTemplate {
            //         template_id = 6,
            //             column_name = "dn"
            //     },
            //     new ColumnTemplate {
            //         template_id = 6,
            //             column_name = "docrefno"
            //     },
            //     new ColumnTemplate {
            //         template_id = 6,
            //             column_name = "inbound"
            //     },
            //     new ColumnTemplate {
            //         template_id = 6,
            //             column_name = "ean"
            //     },
            //     new ColumnTemplate {
            //         template_id = 6,
            //             column_name = "sku"
            //     },
            //     new ColumnTemplate {
            //         template_id = 6,
            //             column_name = "productdescription"
            //     },
            //     new ColumnTemplate {
            //         template_id = 6,
            //             column_name = "entiled"
            //     },
            //     new ColumnTemplate {
            //         template_id = 6,
            //             column_name = "qty_in_ewm"
            //     },
            //     new ColumnTemplate {
            //         template_id = 6,
            //             column_name = "uom"
            //     },
            //     new ColumnTemplate {
            //         template_id = 6,
            //             column_name = "weight"
            //     },
            //     new ColumnTemplate {
            //         template_id = 6,
            //             column_name = "volume"
            //     },
            //     new ColumnTemplate {
            //         template_id = 6,
            //             column_name = "productgroupcode"
            //     },
            //     new ColumnTemplate {
            //         template_id = 6,
            //             column_name = "productgroupname"
            //     },
            //     new ColumnTemplate {
            //         template_id = 6,
            //             column_name = "suppliercode"
            //     },
            //     new ColumnTemplate {
            //         template_id = 6,
            //             column_name = "suppliername"
            //     },
            //     new ColumnTemplate {
            //         template_id = 6,
            //             column_name = "doctype"
            //     }
            // });

            using (var scope = _serviceProvider.CreateScope ()) {
                _msContext = scope.ServiceProvider.GetRequiredService<MasterContext> ();
                var result = _msContext.ArsTblColumnTemplate
                    .Join (_msContext.ArsTblTemplate,
                        ct => ct.TemplateId,
                        t => t.TemplateId, (ct, t) => new { ct, t })
                    .Select (s => new ColumnTemplate {
                        template_id = s.ct.TemplateId,
                            template_name = s.t.TemplateName,
                            column_id = s.ct.ColumnId,
                            column_name = s.ct.ColumnName
                    }).ToList ();

                list.AddRange (result);
            }
            return list;
        }

        public List<CustomerTemplate> GetCustomerTemplate () {

            // 1024 Epson
            // 1091 CBM (SCG)
            // 1174 Acer

            // Report Name	Format	File name	ช่วงวันที่	condition	Email subject
            // รายงานรับ (Receiving  Report)	Epson	Epson-GR-Daily.xlsx	GR Date = Now()-1	Customer code = 0003043853	รายงานรับ (Receiving Report) Epson ประจำวันที่ DD MMM YYYY
            // รายงานรับ (Receiving  Report)	Acer	Acer-GR-Daily.xlsx	GR Date = Now()-1	Customer code = 0003006961	รายงานรับ (Receiving Report) Acer ประจำวันที่ DD MMM YYYY
            // รายงานรับ (Receiving  Report)	CBM	CBM-GR-Daily.xlsx	GR Date = Now()-1	Customer code = 0000000121	รายงานรับ (Receiving Report) CBM ประจำวันที่ DD MMM YYYY
            // รายงานจ่าย (Dispatching  Report)	Epson	Epson-GI-Daily.xlsx	GI Date = Now()-1	Customer code = 0003043853	รายงานจ่าย (Dispatching Report) Epson ประจำวันที่ DD MMM YYYY
            // รายงานจ่าย (Dispatching  Report)	Acer	Acer-GI-Daily.xlsx	GI Date = Now()-1	Customer code = 0003006961	รายงานจ่าย (Dispatching Report) Acer ประจำวันที่ DD MMM YYYY
            // รายงานจ่าย (Dispatching  Report)	CBM	CBM-GI-Daily.xlsx	GI Date = Now()-1	Customer code = 0000000121	รายงานจ่าย (Dispatching Report) CBM ประจำวันที่ DD MMM YYYY

            using (var scope = _serviceProvider.CreateScope ()) {
                _msContext = scope.ServiceProvider.GetRequiredService<MasterContext> ();
                var result = _msContext.ArsTblCustomerTemplate
                    .Join (_msContext.ArsTblCustomer, ct => ct.CustomerId, c => c.CustomerId, (ct, c) => new { ct, c })
                    .Join (_msContext.ArsTblTemplate, et => et.ct.TemplateId, t => t.TemplateId, (et, t) => new { et, t })
                    .Join (_msContext.ArsTblReport, rt => rt.et.ct.ReportId, r => r.ReportId, (rt, r) => new { rt, r })
                    .Select (s => new CustomerTemplate {
                        customer_id = s.rt.et.c.CustomerId,
                            customer_name = s.rt.et.c.CustomerName,
                            report_id = s.r.ReportId,
                            report_name = s.r.ReportName,
                            //report_type_id = s.r.ReportTypeId,
                            template_id = s.rt.t.TemplateId,
                            template_name = s.rt.t.TemplateName,
                            template_path = s.rt.t.TemplatePath
                    }).ToList ();

                return result;
            }

            // return new List<CustomerTemplate> () {
            //     new CustomerTemplate {
            //         template_id = 1,
            //             customer_id = 1024,
            //             customer_name = "Epson",
            //             report_type_id = 1,
            //             report_name = "รายงานรับ (Receiving  Report)",
            //             template_name = "Epson-GR-Daily",
            //             template_path = "CDC/Epson-GR-Daily.xlsx"
            //     },
            //     new CustomerTemplate {
            //         template_id = 2,
            //             customer_id = 1091,
            //             customer_name = "CBM",
            //             report_type_id = 1,
            //             report_name = "รายงานรับ (Receiving  Report)",
            //             template_name = "CBM-GR-Daily",
            //             template_path = "CDC/CBM-GR-Daily.xlsx"
            //     },
            //     new CustomerTemplate {
            //         template_id = 3,
            //             customer_id = 1174,
            //             customer_name = "Acer",
            //             report_type_id = 1,
            //             report_name = "รายงานรับ (Receiving  Report)",
            //             template_name = "Acer-GR-Daily",
            //             template_path = "CDC/Acer-GR-Daily.xlsx"
            //     }, new CustomerTemplate {
            //         template_id = 4,
            //             customer_id = 1024,
            //             customer_name = "Epson",
            //             report_type_id = 3,
            //             report_name = "รายงานจ่าย (Dispatching  Report)",
            //             template_name = "Epson-GI-Daily",
            //             template_path = "CDC/Epson-GI-Daily.xlsx"
            //     },
            //     new CustomerTemplate {
            //         template_id = 5,
            //             customer_id = 1091,
            //             customer_name = "CBM",
            //             report_type_id = 3,
            //             report_name = "รายงานจ่าย (Dispatching  Report)",
            //             template_name = "CBM-GI-Daily",
            //             template_path = "CDC/CBM-GI-Daily.xlsx"
            //     },
            //     new CustomerTemplate {
            //         template_id = 6,
            //             customer_id = 1174,
            //             customer_name = "Acer",
            //             report_type_id = 3,
            //             report_name = "รายงานจ่าย (Dispatching  Report)",
            //             template_name = "Acer-GI-Daily",
            //             template_path = "CDC/Acer-GI-Daily.xlsx"
            //     }
            // };
        }

        public List<EmailAddress> GetEmailAddresses () {

            using (var scope = _serviceProvider.CreateScope ()) {
                _msContext = scope.ServiceProvider.GetRequiredService<MasterContext> ();
                return _msContext.ArsTblEmailaddress.Select (s => new EmailAddress {
                    email_id = s.EmailId,
                        email_address = s.EmailAddress
                }).ToList ();
            }

            // return new List<EmailAddress> () {
            //     new EmailAddress {
            //         email_id = 1,
            //             email_address = "chainimit@csigroups.com"
            //     },
            //     new EmailAddress {
            //         email_id = 2,
            //             email_address = "tanaphum@scg.com"
            //     },
            //     new EmailAddress {
            //         email_id = 3,
            //             email_address = "sutharai@scg.com"
            //     },
            //     new EmailAddress {
            //         email_id = 4,
            //             email_address = "phitcphu@scg.com"
            //     }
            // };
        }

        public List<EmailReportMappingViewModel> GetEmailReportMapping () {
            using (var scope = _serviceProvider.CreateScope ()) {
                _msContext = scope.ServiceProvider.GetRequiredService<MasterContext> ();
                var result = _msContext.ArsTblEmailReportMapping
                    .Join (_msContext.ArsTblEmailaddress, em => em.EmailId, e => e.EmailId, (em, e) => new { em, e })
                    .Join (_msContext.ArsTblTemplate, et => et.em.TemplateId, t => t.TemplateId, (et, t) => new { et, t })
                    .Select (s => new EmailReportMappingViewModel {
                        email_id = s.et.e.EmailId,
                            email_address = s.et.e.EmailAddress,
                            template_id = s.t.TemplateId,
                            template_name = s.t.TemplateName,
                            template_path = s.t.TemplatePath
                    }).ToList ();

                return result;
            }

            // var mapping = new List<EmailReportMapping> () {
            //     new EmailReportMapping {
            //     email_id = 1,
            //     template_id = 1
            //     },
            //     new EmailReportMapping {
            //     email_id = 1,
            //     template_id = 2
            //     },
            //     new EmailReportMapping {
            //     email_id = 1,
            //     template_id = 3
            //     },
            //     new EmailReportMapping {
            //     email_id = 1,
            //     template_id = 4
            //     },
            //     new EmailReportMapping {
            //     email_id = 1,
            //     template_id = 5
            //     },
            //     new EmailReportMapping {
            //     email_id = 1,
            //     template_id = 6
            //     }
            // };
            //     new EmailReportMapping {
            //     email_id = 2,
            //     template_id = 1
            //     },
            //     new EmailReportMapping {
            //     email_id = 2,
            //     template_id = 2
            //     },
            //     new EmailReportMapping {
            //     email_id = 2,
            //     template_id = 3
            //     },
            //     new EmailReportMapping {
            //     email_id = 2,
            //     template_id = 4
            //     },
            //     new EmailReportMapping {
            //     email_id = 2,
            //     template_id = 5
            //     },
            //     new EmailReportMapping {
            //     email_id = 2,
            //     template_id = 6
            //     },
            //     new EmailReportMapping {
            //     email_id = 3,
            //     template_id = 1
            //     },
            //     new EmailReportMapping {
            //     email_id = 3,
            //     template_id = 2
            //     },
            //     new EmailReportMapping {
            //     email_id = 3,
            //     template_id = 3
            //     }, new EmailReportMapping {
            //     email_id = 3,
            //     template_id = 4
            //     },
            //     new EmailReportMapping {
            //     email_id = 3,
            //     template_id = 5
            //     },
            //     new EmailReportMapping {
            //     email_id = 3,
            //     template_id = 6
            //     },
            //     new EmailReportMapping {
            //     email_id = 4,
            //     template_id = 1
            //     },
            //     new EmailReportMapping {
            //     email_id = 4,
            //     template_id = 2
            //     },
            //     new EmailReportMapping {
            //     email_id = 4,
            //     template_id = 3
            //     }, new EmailReportMapping {
            //     email_id = 4,
            //     template_id = 4
            //     },
            //     new EmailReportMapping {
            //     email_id = 4,
            //     template_id = 5
            //     },
            //     new EmailReportMapping {
            //     email_id = 4,
            //     template_id = 6
            //     },
            //     new EmailReportMapping {
            //     email_id = 5,
            //     template_id = 1
            //     },
            //     new EmailReportMapping {
            //     email_id = 5,
            //     template_id = 2
            //     },
            //     new EmailReportMapping {
            //     email_id = 5,
            //     template_id = 3
            //     }, new EmailReportMapping {
            //     email_id = 5,
            //     template_id = 4
            //     },
            //     new EmailReportMapping {
            //     email_id = 5,
            //     template_id = 5
            //     },
            //     new EmailReportMapping {
            //     email_id = 5,
            //     template_id = 6
            //     }
            // };

            // var template = GetCustomerTemplate ();
            // var email = GetEmailAddresses ();
            // var result = mapping.Join (template,
            //         mapping => mapping.template_id,
            //         template => template.template_id,
            //         (m, t) => new { m, t }).Join (email,
            //         mapping => mapping.m.email_id,
            //         mail => mail.email_id,
            //         (mp, em) => new { mp, em })
            //     .Select (s =>
            //         new EmailReportMappingViewModel {
            //             template_id = s.mp.t.template_id,
            //                 template_name = s.mp.t.template_name,
            //                 email_id = s.em.email_id,
            //                 email_address = s.em.email_address
            //         }).ToList ();
            // return result;
        }
    }
}