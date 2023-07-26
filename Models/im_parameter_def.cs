using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class im_parameter_def
    {
        public int store_id { get; set; }
        public string ob_use_base_unit { get; set; }
        public int? base_vol_unit_seq { get; set; }
        public int? base_wght_unit_seq { get; set; }
        public int? base_each_unit_seq { get; set; }
        public double? base_unit_cnv_fctr { get; set; }
        public string base_unit_op { get; set; }
        public short fcst_mthd { get; set; }
        public string ob_search_for_last_price { get; set; }
        public string ob_use_vndr_bid { get; set; }
        public short inven_valuation_mthd { get; set; }
        public short? acctng_close_cycle { get; set; }
        public string ob_sub_qty_on_hand { get; set; }
        public string ob_sub_qty_on_ordr { get; set; }
        public string ob_sub_proj_usage { get; set; }
        public string ob_add_safety_stk { get; set; }
        public string ob_consider_max_qty { get; set; }
        public double? invc_tol_amt { get; set; }
        public string po_prefix { get; set; }
        public short? prior_day_warn_thresh { get; set; }
        public string ob_entry_allowed_past_thresh { get; set; }
        public double? price_fluc_alert_pct { get; set; }
        public string po_diff_tol_type { get; set; }
        public double? po_diff_tol_amt { get; set; }
        public string ob_prior_prd_update_allowed { get; set; }
        public short mtn_pptl_inven { get; set; }
        public int? rpt_usage_unit { get; set; }
        public string ob_concatenate_gl_acct_id { get; set; }
        public string ob_price_fluc_check { get; set; }
        public string ob_chng_ap_rcpt { get; set; }
        public short deflt_rcp_cost_calc { get; set; }
        public int? pos_wght_unit_seq { get; set; }
        public double? invc_tol_pct { get; set; }
        public string ob_change_placed_ordr { get; set; }
        public string ob_auto_aprv_invc { get; set; }
        public double? po_diff_tol_pct { get; set; }
        public short num_sub_cnt_unit { get; set; }
        public int? cod_cash_acct_seq { get; set; }
        public int? cod_check_acct_seq { get; set; }
        public int brr_color { get; set; }
        public int brv_color { get; set; }
        public int brw_color { get; set; }
        public string po_cmnt { get; set; }
        public string ob_max_form_on_open { get; set; }
        public short? deflt_form_size { get; set; }
        public int lang_seq { get; set; }
        public short? timeout { get; set; }
        public short? auto_update_inven { get; set; }
        public short auto_update_mi_theo_cost { get; set; }
        public int? ordr_aseq_seq { get; set; }
        public string ob_run_ordr_aseq { get; set; }
        public string ob_lock_desktop { get; set; }
        public string itm_lst_exclu_lst { get; set; }
        public string vndr_exclu_lst { get; set; }
        public string ob_no_rcv_unit_cnv { get; set; }
        public string ob_ignore_eop_chk { get; set; }
        public int? base_cncy_seq { get; set; }
        public string ob_allowances { get; set; }
        public string ob_multi_cncy { get; set; }
        public string ob_prn_ordr_create { get; set; }
        public string ob_no_itm_to_po { get; set; }
        public string ob_allow_neg_ingrd_qty { get; set; }
        public int? allowance_seq_default { get; set; }
        public short? allowance_modify_days { get; set; }
        public short purging_days { get; set; }
        public int prior_day_task_threshold { get; set; }
        public string ob_use_ilcg { get; set; }
        public string ob_modify_xfer { get; set; }
        public string ob_use_loc { get; set; }
        public string ob_house_cost { get; set; }
        public byte? inven_cnt_sort_ordr { get; set; }
        public string ob_po_multi_ilcg { get; set; }
        public string ob_po_ilcg_con { get; set; }
        public string ob_suspd_post { get; set; }
        public string ob_allow_lst_qty_unit { get; set; }
        public string ob_lst_qty_ovrde { get; set; }
        public string ob_lst_unit_ovrde { get; set; }
        public string ob_allow_non_rcv_itm { get; set; }
        public string ob_rcv_xfer { get; set; }
        public string ob_prn_xfer_create { get; set; }
        public int? dflt_pos_allwn_seq { get; set; }
        public int? deflt_menu_lvl { get; set; }
        public long? multi_user_access_seq { get; set; }
        public string ob_batch_receive { get; set; }
        public string ob_auto_close_accnt_prds { get; set; }
        public int? num_days_close_prds { get; set; }
        public string ob_auto_recon_pslp { get; set; }
        public string ob_ovrde_unit_vndr_bid { get; set; }
        public string ob_prn_rcv_create { get; set; }
        public string ob_not_all_count_null { get; set; }
        public string ob_xfer_between_stores { get; set; }
    }
}
