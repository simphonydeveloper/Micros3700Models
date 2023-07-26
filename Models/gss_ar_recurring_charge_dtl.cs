using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_ar_recurring_charge_dtl
    {
        public int ar_recurring_charge_dtl_seq { get; set; }
        public DateTime creation_date { get; set; }
        public int? emp_seq { get; set; }
        public string description { get; set; }
        public DateTime transaction_start { get; set; }
        public int? gl_account_seq { get; set; }
        public int? term_period { get; set; }
        public int term_period_type { get; set; }
        public decimal amount { get; set; }
        public int? ar_account_seq { get; set; }
        public int? group_seq { get; set; }
    }
}
