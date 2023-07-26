using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class payroll_export_dtl
    {
        public int payroll_export_seq { get; set; }
        public int? deduction_seq { get; set; }
        public int? emp_seq { get; set; }
        public int? job_seq { get; set; }
        public DateTime? payroll_period_startdate { get; set; }
        public DateTime? payroll_period_enddate { get; set; }
        public decimal? reg_rate { get; set; }
        public decimal? ovt_rate { get; set; }
        public decimal? reg_hrs { get; set; }
        public decimal? reg_ttl { get; set; }
        public decimal? ovt_hrs { get; set; }
        public decimal? ovt_ttl { get; set; }
        public decimal? ovt_2_hrs { get; set; }
        public decimal? ovt_2_ttl { get; set; }
        public decimal? ovt_2_rate { get; set; }
        public decimal? ovt_3_hrs { get; set; }
        public decimal? ovt_3_ttl { get; set; }
        public decimal? ovt_3_rate { get; set; }
        public decimal? ovt_4_hrs { get; set; }
        public decimal? ovt_4_ttl { get; set; }
        public decimal? ovt_4_rate { get; set; }
        public DateTime? trans_date { get; set; }
        public DateTime? clk_in_date_tm { get; set; }
        public DateTime? clk_out_date_tm { get; set; }
        public decimal? tip_decl_amt { get; set; }
        public decimal? gross_fb_sls { get; set; }
        public decimal? chg_tip_amt { get; set; }
        public decimal? chg_sls { get; set; }
        public decimal? comm_ttl { get; set; }
        public decimal? emp_svc_tip_ttl { get; set; }
        public decimal? ind_tips_paid_ttl { get; set; }
        public string deduction_name { get; set; }
        public decimal? deduction_pctge { get; set; }
        public decimal? deduction_amt { get; set; }
        public string ob_deduction { get; set; }
        public decimal? prem_pay_hrs { get; set; }
        public decimal? prem_pay_additional_hrs { get; set; }
        public decimal? prem_pay_amt { get; set; }
    }
}
