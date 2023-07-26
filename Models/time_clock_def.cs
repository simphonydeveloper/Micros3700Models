using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class time_clock_def
    {
        public int store_id { get; set; }
        public int? job_tmpl_set_seq { get; set; }
        public int? export_seq { get; set; }
        public short? lab_wk_start_day { get; set; }
        public short? reg_paid_min_brk_duratn { get; set; }
        public short? reg_paid_max_brk_duratn { get; set; }
        public short? reg_unpaid_min_brk_duratn { get; set; }
        public short? reg_unpaid_max_brk_duratn { get; set; }
        public short? minor_paid_min_brk_duratn { get; set; }
        public short? minor_paid_max_brk_duratn { get; set; }
        public short? minor_unpaid_min_brk_duratn { get; set; }
        public short? minor_unpaid_max_brk_duratn { get; set; }
        public short? clk_in_early_grace { get; set; }
        public short? clk_in_late_grace { get; set; }
        public short? clk_out_early_grace { get; set; }
        public short? clk_out_late_grace { get; set; }
        public short? lab_wk_sched_day { get; set; }
        public short? num_days_time_clock_sched { get; set; }
        public string emp_meal_deduction_desc { get; set; }
        public string lab_cat_1_name { get; set; }
        public string lab_cat_2_name { get; set; }
        public string lab_cat_3_name { get; set; }
        public string lab_cat_4_name { get; set; }
        public string ob_all_labor_to_clk_in_date { get; set; }
        public string ob_decl_tips_only1 { get; set; }
        public string ob_salary_clk_in { get; set; }
        public string ob_post_emp_meal_deduction { get; set; }
        public string ob_rvc065_prompt_for_brk { get; set; }
        public string ob_rvc066_auth_early_brk { get; set; }
        public string ob_rvc067_auth_late_brk { get; set; }
        public string ob_rvc068_prompt_paid_brk { get; set; }
        public string ob_rvc069_auth_early_pd_brk { get; set; }
        public string ob_rvc070_auth_late_paid_brk { get; set; }
        public string ob_rvc072_use_tm_clk_sched { get; set; }
        public string ob_rvc074_auth_early_in_grc { get; set; }
        public string ob_rvc076_auth_late_in_grc { get; set; }
        public string ob_rvc078_auth_early_out_grc { get; set; }
        public string ob_rvc080_auth_late_out_grc { get; set; }
        public string ob_display_unsched_jobs { get; set; }
        public string ob_rsvd01 { get; set; }
        public string payroll_export_prog_param { get; set; }
        public int? num_rsvd02 { get; set; }
        public string str_rsvd02 { get; set; }
        public short? num_lines_on_tm_card { get; set; }
        public DateTime? pay_period_start_date { get; set; }
        public string payroll_type { get; set; }
        public short? num_days_time_card_dtl { get; set; }
        public int? num_hrs_labor_week { get; set; }
        public DateTime? rot_start_date { get; set; }
        public string payroll_export_ext_program { get; set; }
        public short srg_stds_time_unit { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public string ob_enforce_sched_brk { get; set; }
        public string ob_enable_sched_pay { get; set; }
        public short? num_days_reqmnt { get; set; }
        public short? auto_sched_shf_len { get; set; }
        public string ob_no_dly_otm_in_weekly { get; set; }
        public string ob_enforce_lab_perc { get; set; }
        public decimal? sched_lab_perc { get; set; }
        public string ob_enforce_emp_max_hrs { get; set; }
        public string ob_unique_section_asgmnt { get; set; }
        public string reqmnt_fill_type { get; set; }
        public string ob_require_schedule_approval { get; set; }
        public string skill_lvl_precedence { get; set; }
        public string ob_error_to_sched_unavailable { get; set; }
        public short? days_keep_export_dtl { get; set; }
        public int? default_payroll_adj_reason { get; set; }
        public string ob_weighted_average_ot { get; set; }
        public short? recent_clock_out_minutes { get; set; }
    }
}
