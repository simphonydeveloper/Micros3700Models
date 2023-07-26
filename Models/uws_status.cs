using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class uws_status
    {
        public int uws_seq { get; set; }
        public int? cshr_ttl_seq { get; set; }
        public short? next_trans_num { get; set; }
        [Column("override")]
        public short? override_2 { get; set; }
        public int? serial_num_1 { get; set; }
        public int? serial_num_2 { get; set; }
        public string ob_su_is_online { get; set; }
        public DateTime? su_online_status_updated { get; set; }
        public int? ob_flags { get; set; }
        public int? cm_drawer_1_till_assigned { get; set; }
        public int? cm_drawer_2_till_assigned { get; set; }
        public int? cm_drawer_1_till_pull_alert { get; set; }
        public int? cm_drawer_2_till_pull_alert { get; set; }
        public string mStation_id { get; set; }
    }
}
