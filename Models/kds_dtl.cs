using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class kds_dtl
    {
        public int kds_trans_seq { get; set; }
        public string kds_trans_id { get; set; }
        public int? ord_dvc_seq { get; set; }
        public string is_app { get; set; }
        public string is_high_priority { get; set; }
        public int? peak_alert_level { get; set; }
        public int? signed_in_emp { get; set; }
        public DateTime? sent_time { get; set; }
        public DateTime? start_time { get; set; }
        public DateTime? done_time { get; set; }
        public int? mi_cnt { get; set; }
        public DateTime? park_time_start { get; set; }
        public DateTime? elapsed_park_time { get; set; }
        public DateTime? last_recall_time { get; set; }
        public DateTime? last_recall_done_time { get; set; }
        public int qsr_mi_cnt { get; set; }
        public DateTime? user_start_time { get; set; }
        public int? course { get; set; }
        public int? SIPS_mi_seq { get; set; }
        public int? SIPS_net_prep_time { get; set; }
        public string SIPS_prep_time_modifiers { get; set; }
    }
}
