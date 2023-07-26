using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_customer_status
    {
        public int customer_seq { get; set; }
        public int? order_count { get; set; }
        public decimal? order_total { get; set; }
        public DateTime? last_order { get; set; }
        public DateTime? last_inactive { get; set; }
    }
}
