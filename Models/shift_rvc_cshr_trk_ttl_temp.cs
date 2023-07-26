using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class shift_rvc_cshr_trk_ttl_temp
    {
        public int rvc_seq { get; set; }
        public int cshr_ttl_seq { get; set; }
        public int shift_seq { get; set; }
        public int trk_grp_seq { get; set; }
        public int trk_ttl_seq { get; set; }
        public int? cnt { get; set; }
        public decimal? ttl { get; set; }
        public int? ttl_type { get; set; }
    }
}
