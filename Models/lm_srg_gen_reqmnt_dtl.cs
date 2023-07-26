using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_srg_gen_reqmnt_dtl
    {
        public int srg_gen_reqmnt_seq { get; set; }
        public int job_seq { get; set; }
        public int? day_part_seq { get; set; }
        public int? intv_val { get; set; }
        public int reqmnt { get; set; }
        public DateTime sched_date { get; set; }
        public string ob_altered { get; set; }
    }
}
