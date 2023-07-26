using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class ordr_reqn_dtl
    {
        public int ordr_seq { get; set; }
        public DateTime? ordr_prd_start_date { get; set; }
        public DateTime? ordr_prd_end_date { get; set; }
        public string ob_sub_qty_on_hand { get; set; }
        public string ob_sub_qty_on_ordr { get; set; }
        public string ob_sub_proj_usage { get; set; }
        public string ob_add_safety_stk { get; set; }
        public string ob_consider_max_qty { get; set; }
        public string ob_ordr_place_date { get; set; }
    }
}
