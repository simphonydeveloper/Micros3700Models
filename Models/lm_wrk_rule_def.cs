using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_wrk_rule_def
    {
        public int wrk_rule_seq { get; set; }
        public int? obj_num { get; set; }
        public string name { get; set; }
        public short? min_hrs_wk { get; set; }
        public short? max_hrs_wk { get; set; }
        public short? min_hrs_day { get; set; }
        public short? max_hrs_day { get; set; }
        public short? min_day_off { get; set; }
        public short? num_consec_day_off { get; set; }
    }
}
