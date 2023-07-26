using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class acct_def
    {
        public int acct_seq { get; set; }
        public int? acct_grp_seq { get; set; }
        public int? acct_class_seq { get; set; }
        public int? gl_acct_id { get; set; }
        public string acct_desc { get; set; }
        public int obj_num { get; set; }
        public short ob_can_rcv { get; set; }
        public short option_type { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public long? multi_user_access_seq { get; set; }
    }
}
