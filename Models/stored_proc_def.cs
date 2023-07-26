using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class stored_proc_def
    {
        public int stored_proc_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public string proc_id { get; set; }
        public string obj_type { get; set; }
        public string ob_user_visible { get; set; }
        public string ob_rsvd01 { get; set; }
        public string ob_rsvd02 { get; set; }
        public string product_mask { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
