using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_sched_grp_access_def
    {
        public int sched_grp_seq { get; set; }
        public int emp_bo_class_seq { get; set; }
        public short? bus_op_access { get; set; }
    }
}
