using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_hist_otm_rule_dtl
    {
        public int otm_rule_hist_seq { get; set; }
        public int? log_seq { get; set; }
        public int? otm_rule_seq { get; set; }
        public string ob_end_lab_wk_precise { get; set; }
        public string ob_end_lab_date_precise { get; set; }
    }
}
