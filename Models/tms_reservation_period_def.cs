using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class tms_reservation_period_def
    {
        public int reservation_period_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public string ob_recurring { get; set; }
        public DateTime? effective_from { get; set; }
        public DateTime? effective_to { get; set; }
        public short? sched_year { get; set; }
    }
}
