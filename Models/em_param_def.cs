using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_param_def
    {
        public int em_param_seq { get; set; }
        public string deflt_store_send_addr { get; set; }
        public string deflt_store_rcv_addr { get; set; }
        public string deflt_corp_rcv_addr { get; set; }
        public string base_corp_send_addr { get; set; }
        public string dflt_shadow_lc_status { get; set; }
        public string dflt_filter_lc_on_sync { get; set; }
        public string dflt_number_days_to_keep_change_set { get; set; }
        public DateTime? last_exec_pending_delete { get; set; }
    }
}
