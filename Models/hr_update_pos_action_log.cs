using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class hr_update_pos_action_log
    {
        public int hr_update_seq { get; set; }
        public string action { get; set; }
        public DateTime date_time { get; set; }
        public int emp_seq { get; set; }
        public int? obj_num { get; set; }
    }
}
