using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class switch_shift_def
    {
        public int from_emp_seq { get; set; }
        public int to_emp_seq { get; set; }
        public int original_tm_clk_sched_seq { get; set; }
        public DateTime clk_in_date_tm { get; set; }
        public DateTime clk_out_date_tm { get; set; }
        public int? job_seq { get; set; }
        public int? request_by { get; set; }
        public DateTime? request_date { get; set; }
        public int? agreed_to_by { get; set; }
        public int? disagreed_to_by { get; set; }
        public DateTime? agreed_to_date { get; set; }
        public int? approved_by { get; set; }
        public int? disapproved_by { get; set; }
        public DateTime? approval_date { get; set; }
    }
}
