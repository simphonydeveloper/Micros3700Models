using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class time_card_dtl
    {
        public int emp_seq { get; set; }
        public int tm_card_seq { get; set; }
        public int job_seq { get; set; }
        public int? rvc_seq { get; set; }
        public int? tm_clk_sched_seq { get; set; }
        public DateTime clk_in_date_tm { get; set; }
        public DateTime clk_in_gmt_date_tm { get; set; }
        public string clk_in_status { get; set; }
        public DateTime? clk_out_date_tm { get; set; }
        public DateTime? clk_out_gmt_date_tm { get; set; }
        public string clk_out_status { get; set; }
        public int? labor_week { get; set; }
        public decimal? reg_hrs { get; set; }
        public decimal? reg_ttl { get; set; }
        public decimal? ovt_hrs { get; set; }
        public decimal? ovt_ttl { get; set; }
        public decimal? ovt_2_hrs { get; set; }
        public decimal? ovt_2_ttl { get; set; }
        public decimal? ovt_3_hrs { get; set; }
        public decimal? ovt_3_ttl { get; set; }
        public decimal? ovt_4_hrs { get; set; }
        public decimal? ovt_4_ttl { get; set; }
        public decimal? accum_reg_hrs { get; set; }
        public decimal? accum_ovt_hrs { get; set; }
        public decimal? accum_dly_reg_hrs { get; set; }
        public decimal? accum_dly_ovt_hrs { get; set; }
        public short? consec_days { get; set; }
        public DateTime? labor_date { get; set; }
        public string computed_flag { get; set; }
        public string ob_exported { get; set; }
        public string ob_exclude_otm_calc { get; set; }
        public string ob_exclude_lab_cost_calc { get; set; }
        public decimal? tip_decl_amt { get; set; }
        public decimal? gross_fb_sls { get; set; }
        public decimal? chg_tip_amt { get; set; }
        public decimal? chg_sls { get; set; }
        public int? xref_num { get; set; }
        public int? accum_days { get; set; }
        public DateTime? inserted_date { get; set; }
        public string ob_salaried { get; set; }
        public decimal? comm_ttl { get; set; }
        public decimal? emp_svc_tip_ttl { get; set; }
        public decimal? ind_tips_paid_ttl { get; set; }
        public decimal? prem_pay_hrs { get; set; }
        public decimal? prem_pay_additional_hrs { get; set; }
        public decimal? prem_pay_amt { get; set; }
        public int? auth_emp_seq { get; set; }
        public int? reason_seq { get; set; }
    }
}
