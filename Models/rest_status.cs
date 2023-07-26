using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class rest_status
    {
        public int store_id { get; set; }
        public DateTime? effectivity_last_exec_tm { get; set; }
        public DateTime? db_version_date { get; set; }
        public DateTime? business_date { get; set; }
        public DateTime? last_backup_date { get; set; }
        public string micros_version_num { get; set; }
        public int next_batch_num { get; set; }
        public string em_rest_type { get; set; }
        public int? em_next_sent_msg_id { get; set; }
        public int? em_last_rcv_msg_id { get; set; }
        public string ob_db_invalid { get; set; }
        public DateTime? last_dbs_start { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
