using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class kds_bumpbar_def
    {
        public int kds_bumpbar_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public int? num_rows { get; set; }
        public int? num_cols { get; set; }
        public string ob_rsvd { get; set; }
        public string str_rsvd { get; set; }
        public int? num_rsvd { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
