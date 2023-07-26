using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_job_task_def
    {
        public int job_seq { get; set; }
        public int job_task_seq { get; set; }
        public int? obj_num { get; set; }
        public string name { get; set; }
        public int? cond_fcst_ele_seq { get; set; }
        public short? min_staff { get; set; }
        public short? max_staff { get; set; }
        public string ob_tm_indtrmt { get; set; }
    }
}
