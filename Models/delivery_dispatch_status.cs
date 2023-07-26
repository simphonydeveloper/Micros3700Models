using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class delivery_dispatch_status
    {
        public int rvc_seq { get; set; }
        public DateTime? last_refresh_date { get; set; }
        public UInt16? target_delivery_minutes { get; set; }
        public UInt16? avg_delivery_minutes { get; set; }
        public UInt16? avg_dispatch_sent_seconds { get; set; }
        public UInt16? last_dispatch_count { get; set; }
        public UInt16? avg_dispatch_sent_seconds_srv_prd { get; set; }
        public int? last_srv_period { get; set; }
        public DateTime? last_business_date { get; set; }
        public UInt16 manual_override_early_dt_expo { get; set; }
    }
}
