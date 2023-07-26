using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class kds_toolbar_def
    {
        public int kds_toolbar_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public int? button_width { get; set; }
        public int? button_height { get; set; }
        public int background_color { get; set; }
        public string ob_rsvd01 { get; set; }
        public string ob_rsvd02 { get; set; }
        public string ob_rsvd03 { get; set; }
        public string ob_rsvd04 { get; set; }
        public string str_rsvd01 { get; set; }
        public string str_rsvd02 { get; set; }
        public string str_rsvd03 { get; set; }
        public string str_rsvd04 { get; set; }
        public int? num_rsvd01 { get; set; }
        public int? num_rsvd02 { get; set; }
        public int? num_rsvd03 { get; set; }
        public int? num_rsvd04 { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
