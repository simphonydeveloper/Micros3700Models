using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_sched_param_def
    {
        public int sched_param_seq { get; set; }
        public string com_obj_name { get; set; }
        public string parameters { get; set; }
        public TimeSpan? time_to_run { get; set; }
    }
}
