using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cos_grp_def
    {
        public int cos_grp_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public int? acct_grp_seq { get; set; }
        public long? multi_user_access_seq { get; set; }
    }
}
