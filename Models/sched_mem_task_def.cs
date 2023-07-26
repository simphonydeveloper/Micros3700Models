using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class sched_mem_task_def
    {
        public int sched_seq { get; set; }
        public int sched_mem_seq { get; set; }
        public int? inven_cnt_task_seq { get; set; }
    }
}
