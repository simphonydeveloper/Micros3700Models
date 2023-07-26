using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_job_section_def
    {
        public int job_seq { get; set; }
        public int section_seq { get; set; }
        public decimal? deflt_reg_pay_rate { get; set; }
        public decimal? min_pay_rate { get; set; }
        public decimal? max_reg_pay_rate { get; set; }
        public decimal? max_otm_pay_rate { get; set; }
        public short? min_age { get; set; }
        public DateTime? rate_effective_datetime { get; set; }
    }
}
