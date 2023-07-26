using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_ar_transaction_dtl
    {
        public int ar_transaction_dtl_seq { get; set; }
        public int? ar_account_seq { get; set; }
        public int? gl_account_seq { get; set; }
        public int? customer_seq { get; set; }
        public int? ar_batch_dtl_seq { get; set; }
        public int? ar_invoice_dtl_seq { get; set; }
        public int? gl_period_seq { get; set; }
        public string posted { get; set; }
        public string transaction_type { get; set; }
        public DateTime transaction_date { get; set; }
        public int? emp_seq { get; set; }
        public string treference { get; set; }
        public decimal transaction_amt { get; set; }
        public int? ar_recurring_charge_dtl_seq { get; set; }
        public int? check_num { get; set; }
        public DateTime? chk_open_tm { get; set; }
        public string finalized { get; set; }
        [Column("void")]
        public string void_2 { get; set; }
        public string payment_check { get; set; }
    }
}
