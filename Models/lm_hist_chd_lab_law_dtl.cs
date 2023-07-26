using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_hist_chd_lab_law_dtl
    {
        public int chd_lab_law_hist_seq { get; set; }
        public int? log_seq { get; set; }
        public int? fed_state_law_seq { get; set; }
        public int? otm_rule_seq { get; set; }
        public short? min_age { get; set; }
        public short? max_age { get; set; }
    }
}
