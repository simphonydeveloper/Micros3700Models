using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class macro_def
    {
        public int macro_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public string ob_km01_prompt_optr { get; set; }
        public string ob_km02_enable_qty { get; set; }
        public string pos_type { get; set; }
        public string ob_rsvd02 { get; set; }
        public string ob_rsvd03 { get; set; }
        public string ob_rsvd04 { get; set; }
        public string ob_rsvd05 { get; set; }
        public string ob_rsvd06 { get; set; }
        public string ob_rsvd07 { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public string ob_km08_retain_selected_detail { get; set; }
    }
}
