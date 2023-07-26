using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_price_dependent_item
    {
        public int dep_item_seq { get; set; }
        public int mi_seq { get; set; }
        public string ob_always_round_up { get; set; }
        public string ob_allow_parent_change { get; set; }
        public string user_comment { get; set; }
    }
}
