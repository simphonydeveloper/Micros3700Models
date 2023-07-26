using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class dashboard_employee_ttl
    {
        public int emp_seq { get; set; }
        public string employee { get; set; }
        public int? shift_number { get; set; }
        public decimal? net_sales_ttl { get; set; }
        public int? check_count { get; set; }
        public int? cover_count { get; set; }
        public int? open_checks { get; set; }
        public decimal? discount_ttl { get; set; }
        public decimal? service_chg_ttl { get; set; }
        public int? no_sale_cnt { get; set; }
        public int? void_cnt { get; set; }
        public decimal? void_ttl { get; set; }
        public int? cancel_cnt { get; set; }
        public decimal? cancel_ttl { get; set; }
        public decimal? check_avg { get; set; }
        public decimal? guest_avg { get; set; }
        public string receptacle_seq { get; set; }
        public decimal? cash_pull_accum { get; set; }
        public string tm_clk_status { get; set; }
    }
}
