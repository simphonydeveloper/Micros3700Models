using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class job_def
    {
        public int job_seq { get; set; }
        public int? sched_grp_seq { get; set; }
        public int? otm_rule_seq { get; set; }
        public int? rvc_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public int? job_cat_seq { get; set; }
        public string ob_jc01_decl_tips { get; set; }
        public string ob_jc02_ignore_clk_out_sched { get; set; }
        public string ob_jc04_prn_tip_decl_clk_out { get; set; }
        public string ob_non_clk_incl_in_lab_calc { get; set; }
        public string ob_non_clk_req_num_hrs { get; set; }
        public string ob_non_clk_req_amt { get; set; }
        public string ob_non_clk_rate_deflt_prmry { get; set; }
        public string ob_non_clk_allow_rate_ovrde { get; set; }
        public string ob_decl_ind_tips { get; set; }
        public string ob_tipped { get; set; }
        public short lab_cat { get; set; }
        public string job_type { get; set; }
        public int? emp_class_seq { get; set; }
        public short clk_in_priv_lvl { get; set; }
        public decimal? deflt_reg_pay_rate { get; set; }
        public decimal? min_pay_rate { get; set; }
        public decimal? max_reg_pay_rate { get; set; }
        public decimal? max_otm_pay_rate { get; set; }
        public int? work_hrs_seq { get; set; }
        public short? sched_prty { get; set; }
        public short? min_asgn { get; set; }
        public short? max_asgn { get; set; }
        public short? min_staff { get; set; }
        public short? max_staff { get; set; }
        public int? job_skill_seq { get; set; }
        public short? min_age { get; set; }
        public int? pos_color { get; set; }
        public short reqmnt_mthd { get; set; }
        public DateTime? rate_effective_datetime { get; set; }
        public string ob_rsvd01 { get; set; }
        public string ob_rsvd02 { get; set; }
        public string ob_rsvd03 { get; set; }
        public string ob_rsvd04 { get; set; }
        public string ob_rsvd05 { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public decimal? tip_share_pct { get; set; }
    }
}
