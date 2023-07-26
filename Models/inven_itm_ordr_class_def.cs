using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class inven_itm_ordr_class_def
    {
        public int inven_itm_ordr_class_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public short vndr_seln_mthd { get; set; }
        public int? vndr_seq { get; set; }
        public string ob_vndr_ovrde_allowed { get; set; }
        public string ob_price_ovrde_allowed { get; set; }
        public short ordr_qty_calc_mthd { get; set; }
        public string ob_sub_qty_on_hand { get; set; }
        public string ob_sub_qty_on_ordr { get; set; }
        public string ob_sub_proj_usage { get; set; }
        public string ob_add_safety_stk { get; set; }
        public string ob_consider_max_qty { get; set; }
        public int? par_lvl_seq { get; set; }
        public short? ob_consider_yield { get; set; }
        public string ob_alw_unit_cnv { get; set; }
        public double? max_ordr_recalc_fctr { get; set; }
        public short round_ordr_qty { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public long? multi_user_access_seq { get; set; }
    }
}
