using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class trk_grp_def
    {
        public int trk_grp_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public string ob_grp_in_use { get; set; }
        public DateTime? last_updated_date { get; set; }
        public int? last_updated_by { get; set; }
    }
}
