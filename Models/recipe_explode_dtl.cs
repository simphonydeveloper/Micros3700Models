using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class recipe_explode_dtl
    {
        public int recipe_seq { get; set; }
        public int inven_itm_seq { get; set; }
        public string ob_opn_qty { get; set; }
        public string ob_incl_idl_cost { get; set; }
        public double? qty { get; set; }
        public int? unit_seq { get; set; }
        public string ob_inven_deplete { get; set; }
        public string ob_dirty { get; set; }
        public int? ilcg_seq { get; set; }
        public int recipe_explode_seq { get; set; }
    }
}
