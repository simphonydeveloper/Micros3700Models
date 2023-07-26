using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class time_clock_sched_def
    {
        public int emp_seq { get; set; }
        public int tm_clk_sched_seq { get; set; }
        public int? job_seq { get; set; }
        public int? job_cat_seq { get; set; }
        public DateTime? clk_in_date_tm { get; set; }
        public DateTime? clk_in_gmt_date_tm { get; set; }
        public DateTime? clk_out_date_tm { get; set; }
        public DateTime? clk_out_gmt_date_tm { get; set; }
        public short? override_clk_in_early_grace { get; set; }
        public short? override_clk_in_late_grace { get; set; }
        public short? override_clk_out_early_grace { get; set; }
        public short? override_clk_out_late_grace { get; set; }
        public int? sched_tmpl_seq { get; set; }
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
        public short? vertical_position { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public decimal? prem_pay_hrs { get; set; }
        public decimal? prem_pay_additional_hrs { get; set; }
        public decimal? prem_pay_amt { get; set; }
        public int? section_seq { get; set; }
        public int? reqmnt_skill_lvl { get; set; }
    }
}
