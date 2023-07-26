using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class task_assignment_dtl
    {
        public int task_assignment_seq { get; set; }
        public int rvc_seq { get; set; }
        public int task_seq { get; set; }
        public int emp_seq { get; set; }
        public DateTime start_date_time { get; set; }
        public DateTime? stop_date_time { get; set; }
    }
}
