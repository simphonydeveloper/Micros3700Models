using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class dashboard_kds_detail_ttl
    {
        public int fixed_period_seq { get; set; }
        public string name { get; set; }
        public int? order_time { get; set; }
        public int? line_time { get; set; }
        public int? payment_time { get; set; }
        public int? pickup_time { get; set; }
    }
}
