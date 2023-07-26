using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cm_count_unit_def
    {
        public int count_unit_seq { get; set; }
        public int cm_item_seq { get; set; }
        public string unit_name { get; set; }
        public int? ratio_denominator { get; set; }
        public int? ratio_numerator { get; set; }
        public string ob_depositable { get; set; }
        public string ob_is_denominated { get; set; }
        public string ob_sys_default { get; set; }
        public string ob_auto_count { get; set; }
        public int? res_item_id { get; set; }
    }
}
