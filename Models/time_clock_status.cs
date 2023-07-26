using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class time_clock_status
    {
        public int store_id { get; set; }
        public DateTime? compute_from_clk_in_date_tm { get; set; }
        public DateTime? last_purge_cutoff_date { get; set; }
        public DateTime? tp_last_posted_time { get; set; }
        public DateTime? ttls_last_posted_time { get; set; }
        public DateTime? jc_last_posted_time { get; set; }
        public string ob_export_successful { get; set; }
        public DateTime? sched_posted_time { get; set; }
        public DateTime? wao_tp_last_posted_time { get; set; }
        public DateTime? wao_ttls_last_posted_time { get; set; }
        public DateTime? wao_jc_last_posted_time { get; set; }
    }
}
