using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class trans_analyzer_step_def
    {
        public int ta_seq { get; set; }
        public int ta_step_seq { get; set; }
        public string type { get; set; }
        public string conjunction { get; set; }
        public string column { get; set; }
        [Column("operator")]
        public string operator_2 { get; set; }
        public string range_from { get; set; }
        public string range_to { get; set; }
        public int step_order { get; set; }
        public string obj_list { get; set; }
    }
}
