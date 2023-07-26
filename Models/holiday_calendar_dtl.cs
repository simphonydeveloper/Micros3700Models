using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class holiday_calendar_dtl
    {
        public int holiday_calendar_seq { get; set; }
        public string name { get; set; }
        public DateTime? holiday_date { get; set; }
        public string ob_ovrde_school_day_pattern { get; set; }
    }
}
