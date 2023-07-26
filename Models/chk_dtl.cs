using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class chk_dtl
    {
        public int chk_seq { get; set; }
        public int emp_seq { get; set; }
        public int? order_type_seq { get; set; }
        public string id { get; set; }
        public short chk_num { get; set; }
        public string chk_open { get; set; }
        public int? tbl_seq { get; set; }
        public short? grp { get; set; }
        public int rvc_seq { get; set; }
        public DateTime chk_open_date_time { get; set; }
        public byte[] chk_open_date_time_raw { get; set; }
        public DateTime? chk_clsd_date_time { get; set; }
        public DateTime? tbl_open_date_time { get; set; }
        public byte[] tbl_open_date_time_raw { get; set; }
        public int? uws_seq { get; set; }
        public int? standalone_chk_seq { get; set; }
        public string ob_ocs02_wait_for_auth { get; set; }
        public string ob_ocs03_summ_ttl_prntd { get; set; }
        public string ob_ocs04_auto_svc_enabled { get; set; }
        public string ob_ocs09_pickup_auth { get; set; }
        public string ob_ocs10_tms_created_chk { get; set; }
        public string ob_ocs11_suspended_chk { get; set; }
        public string ob_ocs12_auth_prntd { get; set; }
        public string ob_ccs02_ca_chk { get; set; }
        public string ob_ccs03_fast_trans_chk { get; set; }
        public string ob_ccs04_chk_added { get; set; }
        public string ob_ccs05_chk_cancelled { get; set; }
        public string ob_ccs10_ca_chk_batched { get; set; }
        public string ob_ccs11_chk_edited { get; set; }
        public string ob_ccs17_insuff_bev { get; set; }
        public string ob_high_priority { get; set; }
        public int training_status { get; set; }
        public decimal sub_ttl { get; set; }
        public decimal tax_ttl { get; set; }
        public decimal auto_svc_ttl { get; set; }
        public decimal other_svc_ttl { get; set; }
        public decimal pymnt_ttl { get; set; }
        public decimal amt_due_ttl { get; set; }
        public short chk_prntd_cnt { get; set; }
        public short pg_num { get; set; }
        public short line_find_line_num { get; set; }
        public short cov_cnt { get; set; }
        public short first_remote_ordr_dtl { get; set; }
        public short first_dtl_entry_last_rnd { get; set; }
        public byte[] clsd_seat_map { get; set; }
        public byte[] seat_chk_prntd { get; set; }
        public short num_dtl { get; set; }
        public short num_chk_info_lines { get; set; }
        public int? num_mi_dtl { get; set; }
        public byte[] last_svc_date_time_raw { get; set; }
        public int? last_uws_seq { get; set; }
        public string chk_complete { get; set; }
        public string creation_mode { get; set; }
        public string ob_chk_delivery_xfer { get; set; }
        public string ob_ca_auth_on_chk { get; set; }
        public string ob_chk_inserted { get; set; }
        public string ob_set_begun_next_rnd { get; set; }
        public string ob_rsvd05 { get; set; }
        public string ob_rsvd06 { get; set; }
        public string ob_rsvd07 { get; set; }
        public string ob_items_on_hold { get; set; }
        public decimal? gross_rcpts { get; set; }
        public decimal? chgd_rcpts_ttl { get; set; }
        public string ob_chk_reopened { get; set; }
        public byte[] autofire_time_raw { get; set; }
        public DateTime? autofire_time { get; set; }
        public string ob_bad_check { get; set; }
        public byte[] rmt_order_dvc_mask { get; set; }
        public int? job_seq { get; set; }
        public string ob_delayed_check { get; set; }
        public int? team_seq { get; set; }
        public string ob_pending_auth_saved { get; set; }
        public string kds_order_id { get; set; }
        public short? op_cov_cnt { get; set; }
        public byte[] tray_totaled_seat_map { get; set; }
        public int? void_chk_seq { get; set; }
        public int? reason_seq { get; set; }
        public string ob_automatic_discounting { get; set; }
        public decimal? pending_discount_ttl { get; set; }
        public short? distribution_status { get; set; }
        public string remote_order_device_info_line1 { get; set; }
        public string remote_order_device_info_line2 { get; set; }
        public string remote_order_device_info_line3 { get; set; }
        public string remote_order_device_info_line4 { get; set; }
        public DateTime? xfer_request_tm { get; set; }
        public int? xfer_request_emp_seq { get; set; }
        public string fiscalkey { get; set; }
        public string ob_refund_check_active { get; set; }
        public string ob_rush_order { get; set; }
        public string ob_using_tray_totals { get; set; }
        public string ob_incl_svc_enabled { get; set; }
        public decimal? incl_svc_ttl { get; set; }
        public short? last_dtl_prt_on_demand { get; set; }
        public int? next_dtl_id { get; set; }
        public string ob_api_chk_print_through_pos { get; set; }
        public int? last_tmed_seq { get; set; }
        public string ob_is_api_chk { get; set; }
        public string ob_bev_only { get; set; }
        public UInt16? early_dt_expo_status { get; set; }
        public string ob_early_dt_expo_allowed { get; set; }
        public UInt16? drive_thru_order_pos { get; set; }
        public string ob_expo_tray_release_req { get; set; }
        public string ob_active_dthru_win_order { get; set; }
        public DateTime? chk_put_away_date_time { get; set; }
        public string ob_using_tray_totals_ex { get; set; }
        public short? num_extensibility_info_lines { get; set; }
        public int? chk_extensibility_id { get; set; }
        public string ob_fiscal_lock { get; set; }
    }
}
