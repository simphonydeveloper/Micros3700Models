using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class combo_def
    {
        public int combo_seq { get; set; }
        public int combo_grp_seq { get; set; }
        public int? mi_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public int? priority { get; set; }
        public string ob_rsvd01 { get; set; }
        public string ob_rsvd02 { get; set; }
        public string ob_rsvd03 { get; set; }
        public string ob_rsvd04 { get; set; }
        public string ob_rsvd05 { get; set; }
        public string ob_rsvd06 { get; set; }
        public string ob_rsvd07 { get; set; }
        public string ob_rsvd08 { get; set; }
        public string ob_ac_size { get; set; }
        public string ob_allow_prev_rnd_acr { get; set; }
        public short? override_level { get; set; }
        public int? mlvl_mask { get; set; }
        public string scan_placeholder_immed { get; set; }
        public string ob_force_default_item_confirm { get; set; }
        public string ob_allow_uncombo { get; set; }
    }
}
