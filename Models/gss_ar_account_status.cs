using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_ar_account_status
    {
        public int ar_account_seq { get; set; }
        public decimal? current_total { get; set; }
        public DateTime? last_charge { get; set; }
        public DateTime? last_payment { get; set; }
        public DateTime? last_invoice { get; set; }
    }
}
