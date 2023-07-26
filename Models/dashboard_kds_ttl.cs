using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class dashboard_kds_ttl
    {
        public int? current_fixed_period { get; set; }
        public DateTime? business_date { get; set; }
        public int? alrt_1 { get; set; }
        public int? alrt_2 { get; set; }
        public string drive_thru_time { get; set; }
        public string counter_time { get; set; }
        public string park_time { get; set; }
    }
}
