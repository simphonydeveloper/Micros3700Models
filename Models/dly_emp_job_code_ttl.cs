using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class dly_emp_job_code_ttl
    {
        public DateTime business_date { get; set; }
        public int store_id { get; set; }
        public int emp_seq { get; set; }
        public int job_seq { get; set; }
        public short labor_week { get; set; }
        public decimal reg_hrs { get; set; }
        public decimal reg_ttl { get; set; }
        public decimal otm_hrs { get; set; }
        public decimal otm_ttl { get; set; }
        public decimal? otm_2_hrs { get; set; }
        public decimal? otm_2_ttl { get; set; }
        public decimal? otm_3_hrs { get; set; }
        public decimal? otm_3_ttl { get; set; }
        public decimal? otm_4_hrs { get; set; }
        public decimal? otm_4_ttl { get; set; }
        public decimal non_rvc_reg_hrs { get; set; }
        public decimal non_rvc_reg_ttl { get; set; }
        public decimal non_rvc_otm_hrs { get; set; }
        public decimal non_rvc_otm_ttl { get; set; }
        public decimal? tip_decl_amt { get; set; }
        public decimal? gross_fb_sls { get; set; }
        public decimal? chg_tip_amt { get; set; }
        public decimal? chg_sls { get; set; }
        public decimal? comm_ttl { get; set; }
        public decimal? emp_svc_tip_ttl { get; set; }
        public int em_ttl_repl_seq { get; set; }
        public decimal? ind_tips_paid_ttl { get; set; }
        public decimal? prem_pay_hrs { get; set; }
        public decimal? prem_pay_additional_hrs { get; set; }
        public decimal? prem_pay_amt { get; set; }
    }
}
