using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class dashboard_system_ttl
    {
        public DateTime business_date { get; set; }
        public decimal? net_sales_ttl { get; set; }
        public int? cover_count { get; set; }
        public int? check_count { get; set; }
        public decimal? discount_ttl { get; set; }
        public decimal? labor_dollars { get; set; }
        public decimal? labor_cost { get; set; }
        public int? void_cnt { get; set; }
        public decimal? void_ttl { get; set; }
        public int? cancel_cnt { get; set; }
        public decimal? cancel_ttl { get; set; }
        public int? labor_cost_alert { get; set; }
    }
}
