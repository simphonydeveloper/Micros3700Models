using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class job_otm_lvl_def
    {
        public int job_seq { get; set; }
        public int otm_lvl_seq { get; set; }
        public decimal? deflt_otm_pay_rate { get; set; }
    }
}
