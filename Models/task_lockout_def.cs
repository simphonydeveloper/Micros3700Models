using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class task_lockout_def
    {
        public int task_seq { get; set; }
        public int locked_out_task_seq { get; set; }
        public int lockout_seconds { get; set; }
        public string lock_out_until_task_stop { get; set; }
    }
}
