using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class hist_job_rate_dtl
    {
        public int hist_seq { get; set; }
        public int emp_seq { get; set; }
        public int job_seq { get; set; }
        public int? pay_reason_seq { get; set; }
        public int? job_skill_seq { get; set; }
        public string ob_primary_job { get; set; }
        public decimal? override_reg_pay_rate { get; set; }
        public DateTime? effective_gmt_datetime { get; set; }
        public int? change_by { get; set; }
        public DateTime? change_date { get; set; }
    }
}
