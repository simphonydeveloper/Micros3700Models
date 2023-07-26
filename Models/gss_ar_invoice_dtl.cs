using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_ar_invoice_dtl
    {
        public int ar_invoice_dtl_seq { get; set; }
        public DateTime? creation_date { get; set; }
        public int ar_account_seq { get; set; }
        public decimal prev_amt { get; set; }
        public decimal invoice_amt { get; set; }
        public DateTime? last_printed { get; set; }
    }
}
