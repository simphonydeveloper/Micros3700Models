using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cncy_exch_rate_def
    {
        public int cncy_exch_rule_seq { get; set; }
        public int cncy_exch_rate_type_seq { get; set; }
        public DateTime start_date { get; set; }
        public DateTime? end_date { get; set; }
        public double? exch_rate { get; set; }
        public string rate_src { get; set; }
    }
}
