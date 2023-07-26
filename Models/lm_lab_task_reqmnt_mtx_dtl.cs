using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_lab_task_reqmnt_mtx_dtl
    {
        public int job_seq { get; set; }
        public int job_task_seq { get; set; }
        public DateTime sched_date { get; set; }
        public int? mtx_seq { get; set; }
    }
}
