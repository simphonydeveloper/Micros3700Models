using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_order_mi_dtl
    {
        public int order_mi_dtl_seq { get; set; }
        public int order_ttl_seq { get; set; }
        public int? mi_seq { get; set; }
        public int item_count { get; set; }
        public decimal item_total { get; set; }
        public int? price_level { get; set; }
        public int? price_level_orig { get; set; }
        public int? cndmnt_grp { get; set; }
        public string allow_reorder { get; set; }
        public int? combo_num { get; set; }
        public int? combo_group { get; set; }
        public int? om_type { get; set; }
        public int? om_base_seq { get; set; }
        public int? om_section_info_seq { get; set; }
        public int? om_specialty_seq { get; set; }
        public int? om_topping_seq { get; set; }
        public int? om_topping_mi_seq { get; set; }
        public int? om_modifier_seq { get; set; }
    }
}
