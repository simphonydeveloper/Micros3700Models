using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class hist_emp_job_otm_lvl_dtl
    {
        public int hist_seq { get; set; }
        public int emp_seq { get; set; }
        public int job_seq { get; set; }
        public int otm_lvl_seq { get; set; }
        public decimal? override_otm_pay_rate { get; set; }
        public DateTime? effective_gmt_datetime { get; set; }
        public int? change_by { get; set; }
        public DateTime? change_date { get; set; }
    }
}
