using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class time_card_adjust_dtl
    {
        public int emp_seq { get; set; }
        public int tm_card_seq { get; set; }
        public int time_card_adjmt_seq { get; set; }
        public int? prev_rvc_seq { get; set; }
        public int? prev_job_seq { get; set; }
        public DateTime? prev_clk_in_date_tm { get; set; }
        public string prev_clk_in_status { get; set; }
        public DateTime? prev_clk_out_date_tm { get; set; }
        public string prev_clk_out_status { get; set; }
        public decimal? prev_tip_decl_amt { get; set; }
        public decimal? prev_gross_fb_sls { get; set; }
        public decimal? prev_chg_tip_amt { get; set; }
        public decimal? prev_chg_sls { get; set; }
        public decimal? prev_comm_ttl { get; set; }
        public decimal? prev_emp_svc_tip_ttl { get; set; }
        public decimal? prev_ind_tips_paid_ttl { get; set; }
        public int? adj_emp_seq { get; set; }
        public int? reason_seq { get; set; }
        public DateTime adjmt_date_time { get; set; }
        public string ob_adjusted_tp { get; set; }
        public string ob_adjusted_ttls { get; set; }
        public string ob_adjusted_jc { get; set; }
        public string prev_ob_exclude_otm_calc { get; set; }
        public string prev_ob_exclude_lab_calc { get; set; }
        public string ob_rvc_seq_edit { get; set; }
        public string ob_sys_edit { get; set; }
    }
}
