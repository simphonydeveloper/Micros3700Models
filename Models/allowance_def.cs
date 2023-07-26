using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class allowance_def
    {
        public int allowance_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public string ob_active { get; set; }
        public string ob_usage { get; set; }
        public short? acct_seln_mthd { get; set; }
        public int? ovrde_acct_seq { get; set; }
        public string allowance_id { get; set; }
        public long? multi_user_access_seq { get; set; }
    }
}
