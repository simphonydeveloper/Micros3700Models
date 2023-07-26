using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_coupon_status
    {
        public int coupon_seq { get; set; }
        public int? issued_cnt { get; set; }
        public int? redeemed_cnt { get; set; }
    }
}
