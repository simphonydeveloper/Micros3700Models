using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class other_pay_dtl
    {
        public int job_seq { get; set; }
        public int emp_seq { get; set; }
        public DateTime business_date { get; set; }
        public int pay_seq { get; set; }
        public decimal? pay_amt { get; set; }
        public decimal? pay_hrs { get; set; }
        public decimal? pay_rate { get; set; }
        public DateTime? actual_business_date { get; set; }
        public DateTime? date_posted { get; set; }
        public string other_pay_type { get; set; }
        public string description { get; set; }
        public string ob_jc_posted { get; set; }
        public string ob_ttl_posted { get; set; }
        public string ob_tp_posted { get; set; }
        public string ob_exclude_lab_cost_calc { get; set; }
        public string ob_exported { get; set; }
    }
}
