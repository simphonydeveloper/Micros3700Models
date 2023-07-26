using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class mgr_log_entry_type_def
    {
        public int mgr_log_entry_type_seq { get; set; }
        public int? obj_num { get; set; }
        public string name { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public string description { get; set; }
        public int? sys_type { get; set; }
        public string sys_query { get; set; }
        public string sys_format { get; set; }
        public string ob_info_only { get; set; }
        public string ob_direct_sched { get; set; }
        public short? min_security { get; set; }
        public string ob_direct_on_sched { get; set; }
        public int? LangID_name { get; set; }
        public int? LangID_desc { get; set; }
        public int? LangID_disp { get; set; }
        public long? multi_user_access_seq { get; set; }
    }
}
