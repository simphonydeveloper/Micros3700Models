using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_ar_x_ref_dtl
    {
        public int ar_x_ref_dtl_seq { get; set; }
        public int? ar_account_seq { get; set; }
        public int customer_seq { get; set; }
    }
}
