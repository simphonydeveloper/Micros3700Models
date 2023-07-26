using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_deduction_trans_dtl
    {
        public int deduction_trans_seq { get; set; }
        public int? recurring_deduction_seq { get; set; }
        public int? deduction_seq { get; set; }
        public int? emp_seq { get; set; }
        public string name { get; set; }
        public DateTime? pay_period_start_date { get; set; }
        public DateTime? transaction_date { get; set; }
        public decimal? deduction_amt { get; set; }
        public decimal? deduction_pctge { get; set; }
        public int? deduction_trans_type { get; set; }
        public string ob_exported { get; set; }
    }
}
