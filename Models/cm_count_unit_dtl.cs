using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cm_count_unit_dtl
    {
        public int count_item_seq { get; set; }
        public int ref_count_unit_seq { get; set; }
        public string unit_name { get; set; }
        public int? ratio_numerator { get; set; }
        public int? ratio_denominator { get; set; }
        public string ob_depositable { get; set; }
        public string ob_is_denominated { get; set; }
        public string ob_sys_default { get; set; }
    }
}
