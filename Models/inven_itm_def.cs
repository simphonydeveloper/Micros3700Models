using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class inven_itm_def
    {
        public int inven_itm_seq { get; set; }
        public int inven_itm_lst_seq { get; set; }
        public int ilcg_seq { get; set; }
        public int? inven_loc_seq { get; set; }
        public int inven_cost_grp_seq { get; set; }
        public string name_1 { get; set; }
        public string upper_name_1 { get; set; }
        public string name_2 { get; set; }
        public int obj_num { get; set; }
        public string inven_itm_id { get; set; }
        public string itm_type { get; set; }
        public short prod_type { get; set; }
        public string recipe_type { get; set; }
        public int? recipe_seq { get; set; }
        public DateTime? effective_from_date { get; set; }
        public DateTime? effective_to_date { get; set; }
        public string ob_use_density_fctr { get; set; }
        public double? density_fctr { get; set; }
        public double? density_fctr_vol { get; set; }
        public double? density_fctr_wght { get; set; }
        public int? density_fctr_vol_unit_seq { get; set; }
        public int? density_fctr_wght_unit_seq { get; set; }
        public short? shelf_life_day { get; set; }
        public short? shelf_life_hrs { get; set; }
        public int pur_unit_seq { get; set; }
        public int usage_unit_seq { get; set; }
        public int issue_unit_seq { get; set; }
        public int maj_cnt_unit_seq { get; set; }
        public int sub_cnt_unit_seq { get; set; }
        public int sub_cnt_unit2_seq { get; set; }
        public int sub_cnt_unit3_seq { get; set; }
        public int sub_cnt_unit4_seq { get; set; }
        public int sub_cnt_unit5_seq { get; set; }
        public double yield { get; set; }
        public double? safety_stk_qty { get; set; }
        public double? max_on_hand_qty { get; set; }
        public int? container_seq { get; set; }
        public int inven_itm_class_seq { get; set; }
        public int inven_itm_ordr_class_seq { get; set; }
        public double? var_thresh_amt { get; set; }
        public double? var_thresh_pct { get; set; }
        public double? std_cost_amt { get; set; }
        public double? std_price_incl_tax { get; set; }
        public double? std_price_excl_tax { get; set; }
        public short deflt_closing_mthd { get; set; }
        public string cmnt_ln { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public string ob_complete_batch { get; set; }
        public long? multi_user_access_seq { get; set; }
        public string ob_do_not_allow_waste { get; set; }
        public string ob_inactive { get; set; }
    }
}
