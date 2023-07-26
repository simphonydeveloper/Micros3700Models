using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class ordr_itm_reqn_dtl
    {
        public int ordr_itm_seq { get; set; }
        public int ordr_seq { get; set; }
        public int? vndr_seq { get; set; }
        public double? fcst_usage { get; set; }
        public double? qty_on_hand { get; set; }
        public double? qty_on_ordr { get; set; }
        public double? proj_usage { get; set; }
        public double? safety_stk_qty { get; set; }
        public int? par_lvl_seq { get; set; }
        public double? max_qty_on_hand { get; set; }
        public DateTime? del_date { get; set; }
        public short? ovrde_ordr_qty_calc_mthd { get; set; }
        public string ob_ovrde_vndr_seln_mthd { get; set; }
        public string ob_ovrde_sub_qty_on_hand { get; set; }
        public string ob_ovrde_sub_qty_on_ordr { get; set; }
        public string ob_ovrde_sub_proj_usage { get; set; }
        public string ob_ovrde_add_safety_stk { get; set; }
        public string ob_ovrde_consider_max_qty { get; set; }
        public double? sys_rcmd_ordr_qty { get; set; }
        public short? vndr_seln_mthd { get; set; }
        public short? ob_consider_yield { get; set; }
        public double? yield { get; set; }
        public string ob_rtn { get; set; }
    }
}
