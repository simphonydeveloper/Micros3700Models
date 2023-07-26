using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class aseq_def
    {
        public int aseq_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public short? priority { get; set; }
        public short priv_lvl { get; set; }
        public string ob_system_aseq { get; set; }
        public string ob_hide_on_run_scrn { get; set; }
        public short? icon_id { get; set; }
        public int? sched_class_seq { get; set; }
        public string ob_rsvd01 { get; set; }
        public string ob_rsvd02 { get; set; }
        public string ob_rsvd03 { get; set; }
        public string comments { get; set; }
        public string product_mask { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
