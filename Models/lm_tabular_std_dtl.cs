using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_tabular_std_dtl
    {
        public int job_seq { get; set; }
        public int job_task_seq { get; set; }
        public int task_drv_seq { get; set; }
        public double drv_step { get; set; }
        public short? table_val { get; set; }
    }
}
