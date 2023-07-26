using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cncy_exch_rule_def
    {
        public int cncy_exch_rule_seq { get; set; }
        public int from_cncy_seq { get; set; }
        public int to_cncy_seq { get; set; }
        public int? triangulation_cncy_seq { get; set; }
        public short? rounding_rule { get; set; }
        public string op { get; set; }
    }
}
