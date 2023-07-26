using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class job_rate_def
    {
        public int emp_seq { get; set; }
        public int job_seq { get; set; }
        public int? pay_reason_seq { get; set; }
        public decimal? override_reg_pay_rate { get; set; }
        public short override_job_clk_in { get; set; }
        public int? job_skill_seq { get; set; }
        public DateTime? rate_effective_datetime { get; set; }
        public string ob_primary_job { get; set; }
        public string ob_inactive { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public string ob_omit_from_srg { get; set; }
    }
}
