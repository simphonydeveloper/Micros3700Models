using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class time_clock_sched_brk_def
    {
        public int emp_seq { get; set; }
        public int tm_clk_sched_seq { get; set; }
        public int sched_brk_seq { get; set; }
        public int? brk_seq { get; set; }
        public short? offset { get; set; }
        public short? duration { get; set; }
    }
}
