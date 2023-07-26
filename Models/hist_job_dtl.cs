using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class hist_job_dtl
    {
        public int job_seq { get; set; }
        public int hist_seq { get; set; }
        public decimal? deflt_reg_pay_rate { get; set; }
        public short lab_cat { get; set; }
        public DateTime? effective_gmt_datetime { get; set; }
        public int? otm_rule_seq { get; set; }
        public int? job_cat_seq { get; set; }
        public int? change_by { get; set; }
        public DateTime? change_date { get; set; }
    }
}
