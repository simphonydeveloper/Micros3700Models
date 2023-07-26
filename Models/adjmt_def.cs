using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class adjmt_def
    {
        public int adjmt_seq { get; set; }
        public int? acct_seq { get; set; }
        public int obj_num { get; set; }
        public string adjmt_desc { get; set; }
        public string type { get; set; }
        public short adjmt_type { get; set; }
        public double? amt { get; set; }
        public string ob_amt_ovrde_alw { get; set; }
        public string ob_acct_ovrde_alw { get; set; }
        public string ob_alloc_mthd_ovrde_alw { get; set; }
        public short alloc_mthd { get; set; }
        public int precedence_ordr { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public string adjmt_class { get; set; }
        public string ob_include { get; set; }
        public string ob_include_cost { get; set; }
        public int? cncy_seq { get; set; }
        public long? multi_user_access_seq { get; set; }
    }
}
