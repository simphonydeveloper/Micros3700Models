using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_srg_tmpl_def
    {
        public int srg_tmpl_seq { get; set; }
        public int? day_part_seq { get; set; }
        public int job_tmpl_seq { get; set; }
        public short weekday { get; set; }
        public int? intv_val { get; set; }
        public int reqmnt { get; set; }
    }
}
