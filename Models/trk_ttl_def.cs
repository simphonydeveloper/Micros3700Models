using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class trk_ttl_def
    {
        public int trk_grp_seq { get; set; }
        public int trk_ttl_seq { get; set; }
        public string name { get; set; }
        public short? ttl_type { get; set; }
        public int? ttl_num { get; set; }
        public int? last_updated_by { get; set; }
    }
}
