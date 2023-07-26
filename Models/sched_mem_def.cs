using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class sched_mem_def
    {
        public int sched_seq { get; set; }
        public int sched_mem_seq { get; set; }
        public short sched_mem_type { get; set; }
        public int? last_updated_by { get; set; }
    }
}
