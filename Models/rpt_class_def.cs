using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class rpt_class_def
    {
        public int rpt_class_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public short rpt_cat { get; set; }
        public string obj_type { get; set; }
        public string ob_accepts_date { get; set; }
        public string ob_accepts_rvc { get; set; }
        public string ob_accepts_obj { get; set; }
        public string ob_accepts_shift { get; set; }
        public string ob_accepts_store { get; set; }
        public string ob_accepts_rest_grp { get; set; }
        public string ob_rsvd01 { get; set; }
        public string ob_rsvd02 { get; set; }
        public string ob_rsvd03 { get; set; }
        public string product_mask { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
