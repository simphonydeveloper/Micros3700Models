using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_srg_std_def
    {
        public int srg_std_seq { get; set; }
        public int fcst_ele_seq { get; set; }
        public int day_part_seq { get; set; }
        public int job_seq { get; set; }
        public int lead { get; set; }
        public int lag { get; set; }
        public int offset { get; set; }
        public int offset_start { get; set; }
        public int offset_stop { get; set; }
    }
}
