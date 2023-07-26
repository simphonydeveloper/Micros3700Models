using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class emp_job_otm_lvl_def
    {
        public int emp_seq { get; set; }
        public int job_seq { get; set; }
        public int otm_lvl_seq { get; set; }
        public decimal? override_otm_pay_rate { get; set; }
    }
}
