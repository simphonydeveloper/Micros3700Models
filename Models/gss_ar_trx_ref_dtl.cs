using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_ar_trx_ref_dtl
    {
        public int ar_trx_ref_dtl_seq { get; set; }
        public int charge_seq { get; set; }
        public int payment_seq { get; set; }
        public decimal payment_amt { get; set; }
    }
}
