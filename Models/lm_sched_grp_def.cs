using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_sched_grp_def
    {
        public int sched_grp_seq { get; set; }
        public int? fcst_ele_seq { get; set; }
        public int? obj_num { get; set; }
        public string name { get; set; }
    }
}
