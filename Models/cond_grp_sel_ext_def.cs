using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cond_grp_sel_ext_def
    {
        public int cond_grp_sel_seq { get; set; }
        public int cond_grp_seq { get; set; }
        public int min_val { get; set; }
        public int max_val { get; set; }
        public int? threshold_1 { get; set; }
        public int? threshold_2 { get; set; }
        public int? mlvl_1 { get; set; }
        public int? mlvl_2 { get; set; }
        public string pass_through { get; set; }
        public string ob_use_min_max { get; set; }
        public string ob_skip_on_refill { get; set; }
        public string ob_forced { get; set; }
        public string ob_staydown_on_max { get; set; }
        public short? display_priority { get; set; }
        public string ob_roll_up { get; set; }
    }
}
