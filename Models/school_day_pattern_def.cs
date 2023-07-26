using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class school_day_pattern_def
    {
        public int school_day_pattern_seq { get; set; }
        public string name { get; set; }
        public DateTime? start_date { get; set; }
        public DateTime? end_date { get; set; }
        public string ob_sun_incl { get; set; }
        public string ob_mon_incl { get; set; }
        public string ob_tue_incl { get; set; }
        public string ob_wed_incl { get; set; }
        public string ob_thu_incl { get; set; }
        public string ob_fri_incl { get; set; }
        public string ob_sat_incl { get; set; }
    }
}
