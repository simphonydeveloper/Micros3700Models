using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class employee_lockout_dtl
    {
        public int task_seq { get; set; }
        public int emp_seq { get; set; }
        public DateTime? locked_out_until_datetime { get; set; }
        public int? lock_out_until_stop_task_seq { get; set; }
    }
}
