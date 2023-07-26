using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class mgr_log_def
    {
        public int sched_seq { get; set; }
        public DateTime log_date { get; set; }
        public int occur { get; set; }
        public int? status { get; set; }
        public string description { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public string ob_direct_on_sched { get; set; }
        public short? min_security { get; set; }
    }
}
