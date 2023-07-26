using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_labor_log_dtl
    {
        public int log_seq { get; set; }
        public DateTime? effective_gmt_datetime { get; set; }
    }
}
