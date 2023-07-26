using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class inven_cnt_task_mem_grp_def
    {
        public int inven_cnt_task_seq { get; set; }
        public int inven_cnt_task_mem_seq { get; set; }
        public int? inven_cost_grp_seq { get; set; }
    }
}
