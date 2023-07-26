using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class currency_def
    {
        public int frgn_cncy_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public string descriptor { get; set; }
        public string ob_b01_divide_base { get; set; }
        public string ob_b02_issue_chng_in_forn { get; set; }
        public string ob_b03_prompt_change_frgn { get; set; }
        public string ob_b04_round { get; set; }
        public string ob_b05_rnd_nearest_10_Flag { get; set; }
        public string ob_b06_rnd_tens { get; set; }
        public string ob_rsvd01 { get; set; }
        public string ob_rsvd02 { get; set; }
        public short num_decimal_places { get; set; }
        public double? conversion_rate { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public short insignificant_digits { get; set; }
        public string ob_truncate { get; set; }
    }
}
