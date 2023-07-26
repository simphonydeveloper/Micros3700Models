using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class dev_def
    {
        public int dvc_tbl_seq { get; set; }
        public int? ilds_fast_trans_uws { get; set; }
        public int? ilds_fast_trans_prntr { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string prntr_type { get; set; }
        public string prntr_interface_type { get; set; }
        public int? lan_node_seq { get; set; }
        public short gna { get; set; }
        public short lna { get; set; }
        public int? com_port_seq { get; set; }
        public short? com_port { get; set; }
        public int? baud_rate { get; set; }
        public short num_data_bits { get; set; }
        public short num_stop_bits { get; set; }
        public string parity_type { get; set; }
        public short? idn_id { get; set; }
        public short? roll_prntr_line_feeds { get; set; }
        public short? prntr_cols { get; set; }
        public string filename { get; set; }
        public string opos_prntr_name { get; set; }
        public short? opos_num_line_data_block { get; set; }
        public string opos_highlight_style { get; set; }
        public string kds_device_type { get; set; }
        public int? kds_kitchen_seq { get; set; }
        public int? kds_layout_seq { get; set; }
        public int? kds_bumpbar_seq { get; set; }
        public int? kds_toolbar_seq { get; set; }
        public string kds_toolbar_location { get; set; }
        public int? kds_license_code { get; set; }
        public int? kds_num_chit_cols { get; set; }
        public int? kds_pickup_alert1 { get; set; }
        public int? kds_pickup_alert2 { get; set; }
        public int? kds_selection_timeout { get; set; }
        public string kds_wallpaper_id { get; set; }
        public int? kds_num_table_cols { get; set; }
        public short? ilds_dc_mode { get; set; }
        public string ob_ilds_extended_msg { get; set; }
        public string ob_ilds_single_msg { get; set; }
        public string ob_ilds_do_not_mix_msg_types { get; set; }
        public string ob_dev01_prn_graphics_avail { get; set; }
        public string ob_opos_multi_station_prntr { get; set; }
        public string ob_opos_rel_after_print_job { get; set; }
        public string ob_opos_no_close_prog_exit { get; set; }
        public string ob_opos_use_poll_status { get; set; }
        public string ob_opos_near_empty_not_empty { get; set; }
        public string ob_suppress_prnt_err_in_sar { get; set; }
        public int? kds_num_rows { get; set; }
        public int? kds_serpentine_mode { get; set; }
        public int? panel_layout { get; set; }
        public int? num_panels { get; set; }
        public string ob_kds_rsvd01 { get; set; }
        public string ob_kds_rsvd02 { get; set; }
        public string ob_kds_rsvd03 { get; set; }
        public string ob_kds_rsvd04 { get; set; }
        public int? num_kds_rsvd01 { get; set; }
        public int? num_kds_rsvd02 { get; set; }
        public int? num_kds_rsvd03 { get; set; }
        public int? num_kds_rsvd04 { get; set; }
        public string str_kds_rsvd01 { get; set; }
        public string str_kds_rsvd02 { get; set; }
        public string ob_rsvd01 { get; set; }
        public string ob_rsvd02 { get; set; }
        public string ob_rsvd03 { get; set; }
        public string ob_rsvd04 { get; set; }
        public string ob_rsvd05 { get; set; }
        public string ob_rsvd06 { get; set; }
        public string ob_rsvd07 { get; set; }
        public string ob_prntr_dest_sel_entry { get; set; }
        public string ob_kds_rsvd { get; set; }
        public string str_kds_rsvd { get; set; }
        public int? num_kds_rsvd { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public int? kds_sos_tbl_dtl_timeout { get; set; }
        public int? kds_se_video_id { get; set; }
        public int? kds_se_card_id { get; set; }
        public string kds_se_ip_addr { get; set; }
        public string kds_platform_type { get; set; }
        public string ob_ilds_send_voids { get; set; }
        public string ob_ilds_send_confirm_msg { get; set; }
        public string ob_ilds_send_tbl_nbr { get; set; }
        public string KDS_PRODUCTION_LOCATION { get; set; }
        public int? production_count_col { get; set; }
        public int? kds_order_type_font { get; set; }
        public int? kds_item_type_font { get; set; }
        public int? kds_table_dtl_toolbar_seq { get; set; }
        public string ob_enable_kds_start_location { get; set; }
        public short? kds_frame_start_x { get; set; }
        public short? kds_frame_start_y { get; set; }
        public short? kds_frame_width { get; set; }
        public short? kds_frame_height { get; set; }
        public int? kds_recall_list_col1_type { get; set; }
        public int? kds_recall_list_col1_width { get; set; }
        public int? kds_recall_list_col2_type { get; set; }
        public int? kds_recall_list_col2_width { get; set; }
        public int? kds_recall_list_col3_type { get; set; }
        public int? kds_recall_list_col3_width { get; set; }
        public int? kds_recall_list_col4_type { get; set; }
        public int? kds_recall_list_col4_width { get; set; }
        public int? kds_recall_list_col5_type { get; set; }
        public int? kds_recall_list_col5_width { get; set; }
        public int? kds_recall_list_col6_type { get; set; }
        public int? kds_recall_list_col6_width { get; set; }
        public string ob_kds_enable_item_select { get; set; }
        public string ob_kds_disable_item_dbl_bump { get; set; }
        public string ob_kds_order_tm_0_is_chk_start { get; set; }
        public int kds_combo_subitem_indent_pixels { get; set; }
        public int kds_combo_subitem_rel_font_size { get; set; }
    }
}
