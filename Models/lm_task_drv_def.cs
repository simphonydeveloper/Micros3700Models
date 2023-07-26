using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_task_drv_def
    {
        public int job_seq { get; set; }
        public int job_task_seq { get; set; }
        public int task_drv_seq { get; set; }
        public double cond_val { get; set; }
        public short concy_type { get; set; }
        public short? concy_val { get; set; }
        public short? concy_origin { get; set; }
        public short? dstrb_type { get; set; }
        public short? dstrb_day { get; set; }
        public short? dstrb_start_tm { get; set; }
        public short? dstrb_stop_tm { get; set; }
        public int? work_hrs_seq { get; set; }
        public short? reqmnt_gen_mthd { get; set; }
        public int? fmla_seq { get; set; }
        public int? fcst_ele_seq { get; set; }
    }
}
