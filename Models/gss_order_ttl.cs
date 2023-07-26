using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_order_ttl
    {
        public int order_ttl_seq { get; set; }
        public int customer_seq { get; set; }
        public string favorite { get; set; }
        public int check_num { get; set; }
        public DateTime chk_clsd_tm { get; set; }
        public DateTime chk_open_tm { get; set; }
        public DateTime chk_delivery_tm { get; set; }
        public decimal chk_ttl { get; set; }
        public decimal chk_tax { get; set; }
    }
}
