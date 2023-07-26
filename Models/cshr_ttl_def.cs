using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cshr_ttl_def
    {
        public int cshr_ttl_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public short? cshr_main_mlvl { get; set; }
        public short? cshr_sub_mlvl { get; set; }
        public int? su_trk_grp_seq { get; set; }
        public string ob_cshr01_dont_prn_bal { get; set; }
        public string ob_cshr02_pop_up { get; set; }
        public string ob_rsvd01 { get; set; }
        public string ob_rsvd02 { get; set; }
        public string ob_rsvd03 { get; set; }
        public string ob_rsvd04 { get; set; }
        public string ob_rsvd05 { get; set; }
        public string ob_rsvd06 { get; set; }
        public string ob_rsvd07 { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
