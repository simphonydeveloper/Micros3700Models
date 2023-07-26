using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class rest_pricing_def
    {
        public int rest_pricing_seq { get; set; }
        public decimal? em_chg_set_seq { get; set; }
        public int store_id { get; set; }
        public int price_grp_seq { get; set; }
        public int? price_tier_seq { get; set; }
        public int? prev_price_tier_seq { get; set; }
        public string em_repl_status { get; set; }
        public DateTime? effective_from { get; set; }
        public DateTime? effective_to { get; set; }
    }
}
