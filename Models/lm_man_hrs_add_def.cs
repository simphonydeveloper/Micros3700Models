using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_man_hrs_add_def
    {
        public DateTime sched_date { get; set; }
        public int emp_seq { get; set; }
        public double? hours { get; set; }
    }
}
