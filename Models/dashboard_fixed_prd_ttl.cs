using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class dashboard_fixed_prd_ttl
    {
        public int? current_fixed_period { get; set; }
        public int fixed_period_seq { get; set; }
        public string name { get; set; }
        public decimal? net_sls_ttl { get; set; }
        public int? chk_cnt { get; set; }
        public int? cov_cnt { get; set; }
        public decimal? labor_dollars { get; set; }
        public decimal? labor_cost { get; set; }
        public int? labor_cost_alert { get; set; }
        public int? sales_alert { get; set; }
        public string sales_up { get; set; }
    }
}
