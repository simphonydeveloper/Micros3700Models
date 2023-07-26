using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class hist_ttl_class_def
    {
        public int hist_ttl_type_seq { get; set; }
        public int obj_num { get; set; }
        public int? trk_grp_seq { get; set; }
        public string name { get; set; }
        public string ob_do_not_create_ttl { get; set; }
        public string ob_rsvd01 { get; set; }
        public string ob_rsvd02 { get; set; }
        public string ob_rsvd03 { get; set; }
        public string ob_rsvd04 { get; set; }
        public string ob_rsvd05 { get; set; }
        public string ob_rsvd06 { get; set; }
        public string ob_rsvd07 { get; set; }
        public short? num_days_history { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
