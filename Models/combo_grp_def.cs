using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class combo_grp_def
    {
        public int combo_grp_seq { get; set; }
        public int? ts_style_seq { get; set; }
        public string name { get; set; }
        public int obj_num { get; set; }
        public int? hht_ts_style_seq { get; set; }
        public string ob_combo_dsc_override { get; set; }
        public short default_color { get; set; }
        public int? com_ts_style_seq { get; set; }
        public int? com_hht_ts_style_seq { get; set; }
        public int? combo_grp_ext_seq { get; set; }
    }
}
