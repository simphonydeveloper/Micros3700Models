using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class price_grp_status
    {
        public int price_grp_seq { get; set; }
        public int? active_price_tier_seq { get; set; }
    }
}
