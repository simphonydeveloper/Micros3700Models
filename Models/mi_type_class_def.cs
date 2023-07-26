using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class mi_type_class_def
    {
        public int mi_type_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public string ob_mi01_preset { get; set; }
        public string ob_mi03_cond { get; set; }
        public string ob_mi21_cond_prefix { get; set; }
        public string ob_mi39_match_cond_cnt { get; set; }
        public string ob_mi05_ref_req { get; set; }
        public string ob_mi06_validation_req { get; set; }
        public string ob_mi17_add_to_cov_cnt { get; set; }
        public string ob_mi18_add_to_auto_svc { get; set; }
        public string ob_mi19_enable_multi_prices { get; set; }
        public string ob_mi20_sub_lvl_for_prices { get; set; }
        public string ob_mi22_allow_item_dsc { get; set; }
        public string ob_mi23_fixed_price_item { get; set; }
        public string ob_mi24_upcharge_item { get; set; }
        public string ob_mi25_price_on_order_chit { get; set; }
        public string ob_mi26_both_names_on_chk { get; set; }
        public string ob_mi41_name_2_only_on_chk { get; set; }
        public string ob_mi45_2_names_on_order_cht { get; set; }
        public string ob_mi35_name_2_only_ordr_cht { get; set; }
        public string ob_mi40_wout_par_on_ordr_cht { get; set; }
        public string ob_mi34_override_prn_grp { get; set; }
        public string ob_mi43_prn_mlvl_prefix { get; set; }
        public string ob_mi36_name_2_on_ts { get; set; }
        public string ob_mi02_do_not_report { get; set; }
        public string ob_mi27_not_in_dtl { get; set; }
        public string ob_mi28_req_weight_entry { get; set; }
        public string ob_mi29_incl_in_repeat_rnd { get; set; }
        public string ob_mi42_rpt_prev_rnd_mlvl { get; set; }
        public string ob_mi30_lds_item { get; set; }
        public string ob_mi33_incr_seat_num { get; set; }
        public string ob_mi37_item_is_apptzr { get; set; }
        public string ob_mi38_item_is_bev { get; set; }
        public string ob_negative_open_price { get; set; }
        public string ob_item_shareable { get; set; }
        public string ob_retail_item { get; set; }
        public string ob_fcr_ff_itm { get; set; }
        public string ob_fcr_nn_itm { get; set; }
        public string ob_override_items_are_app { get; set; }
        public string ob_count_mi { get; set; }
        public string ob_rsvd04 { get; set; }
        public string ob_rsvd05 { get; set; }
        public string ob_rsvd06 { get; set; }
        public string ob_rsvd07 { get; set; }
        public string ob_rsvd08 { get; set; }
        public string ob_rsvd09 { get; set; }
        public string ob_rsvd10 { get; set; }
        public short priv_lvl { get; set; }
        public int sls_itmzr_seq { get; set; }
        public int? tax_class_seq { get; set; }
        public short dsc_itmzr { get; set; }
        public short svc_itmzr { get; set; }
        public decimal? halo { get; set; }
        public short print_grp { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public int? kds_highlight_scheme_seq { get; set; }
        public int? ob_flags { get; set; }
        public string ob_forgive_incl_tax { get; set; }
        public int? dining_course { get; set; }
        public short? max_refills { get; set; }
        public string refill_desc { get; set; }
        public string ob_allow_refill { get; set; }
        public string ob_override_parent_print_class { get; set; }
        public string ob_merge_parent_print_class { get; set; }
        public string ob_force_tbl_entry { get; set; }
        public string ob_suppress_combomeal_cond_ttl { get; set; }
        public string ob_om_topping { get; set; }
        public string ob_om_specialty { get; set; }
        public string ob_both_names_on_ts { get; set; }
        public string ob_show_mi_on_ochk_slu { get; set; }
        public string ob_auto_dsc_meal { get; set; }
        public string ob_auto_dsc_cond { get; set; }
        public short? prefix_type { get; set; }
        public string ob_placeholder { get; set; }
        public string ob_suppress_from_net_sls_ttl { get; set; }
        public string ob_print_cond_charge { get; set; }
        public byte rear_display_name { get; set; }
        public string ob_suppress_match_cndmnt_cnt { get; set; }
        public string ob_hide_touchscreen_prefix_key { get; set; }
        public string ob_prefix_allows_print { get; set; }
        public string ob_suppress_build_scrn { get; set; }
        public byte? hide_cond_prefix_type { get; set; }
        public string ob_kds_priority_above_normal { get; set; }
        public string ob_do_not_allow_waste { get; set; }
        public byte ts_detail_name { get; set; }
        public string ob_display_barcode_ts { get; set; }
        public string ob_print_barcode_gst_check { get; set; }
        public string ob_print_barcode_rem_ordr_dev { get; set; }
        public string ob_print_nlu_gst_check { get; set; }
        public string ob_print_nlu_rod { get; set; }
        public string ob_scan_for_cndm_placeholder { get; set; }
        public string ob_force_alt_order_routing { get; set; }
        public string ob_limit_qty_to_1 { get; set; }
    }
}
