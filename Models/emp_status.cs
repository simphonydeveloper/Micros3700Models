using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class emp_status
    {
        public int emp_seq { get; set; }
        public int? cshr_ttl_seq { get; set; }
        public int? job_seq { get; set; }
        public short training_status { get; set; }
        public int? uws_seq { get; set; }
        public string ob_ebs01_bank_declared { get; set; }
        public string ob_ebs02_media_declared { get; set; }
        public string ob_es01_prn_last_clk_out { get; set; }
        public string ob_es03_temp_clk_in_reset { get; set; }
        public string tm_clk_status { get; set; }
        public short tm_card_num { get; set; }
        public short tm_card_pg_num { get; set; }
        public short tm_card_line_find_line_num { get; set; }
        public short num_clk_in_outs { get; set; }
        public DateTime? brk_or_sched_clk_out_tm { get; set; }
        public int shift_seq { get; set; }
        public DateTime? prev_shift_end_time { get; set; }
        public int? lds_rvc_seq { get; set; }
        public decimal update_count { get; set; }
        public int? current_rvc_seq { get; set; }
        public DateTime? emp_rot_start_date { get; set; }
        public string lock_status { get; set; }
        public byte? driver_status { get; set; }
        public int? last_posted_salary_week { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public int? cm_accounting_method { get; set; }
        public string till_assignment { get; set; }
        public DateTime? last_dispatch_tm { get; set; }
        public DateTime? target_return_tm { get; set; }
        public DateTime? actual_return_tm { get; set; }
        public DateTime? mylabor_clk_in_tm { get; set; }
    }
}
