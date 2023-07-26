using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class time_clock_approved_day_dtl
    {
        public int approved_day_seq { get; set; }
        public DateTime schedule_date { get; set; }
        public string ob_approved { get; set; }
    }
}
