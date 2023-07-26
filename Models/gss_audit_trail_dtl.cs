using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_audit_trail_dtl
    {
        public int audit_trail_dtl_seq { get; set; }
        public int? ar_account_seq { get; set; }
        public int? gl_account_seq { get; set; }
        public int? customer_seq { get; set; }
        public int? ar_batch_dtl_seq { get; set; }
        public int? ar_invoice_dtl_seq { get; set; }
        public string transaction_type { get; set; }
        public DateTime transaction_date { get; set; }
        public int? emp_seq { get; set; }
        public decimal? transaction_amt { get; set; }
    }
}
