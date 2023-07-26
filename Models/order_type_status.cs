using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class order_type_status
    {
        public int order_type_seq { get; set; }
        public UInt16? promise_time_adjust { get; set; }
        public DateTime? last_update_tm { get; set; }
        public decimal? kds_recent_performance_pcnt { get; set; }
        public UInt16? kds_workload_adjust_minutes { get; set; }
    }
}
