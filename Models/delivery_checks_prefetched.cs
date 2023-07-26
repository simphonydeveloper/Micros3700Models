using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class delivery_checks_prefetched
    {
        public int chk_seq { get; set; }
        public int? chk_emp_seq { get; set; }
        public short? chk_num { get; set; }
        public string chk_id { get; set; }
        public int? chk_num_mi_dtl { get; set; }
        public int? chk_ca_count { get; set; }
        public DateTime? chk_open_tm { get; set; }
        public decimal? chk_ttl { get; set; }
        public decimal? chk_ttl_due { get; set; }
        public decimal? pending_discount_ttl { get; set; }
        public decimal? payment_ttl { get; set; }
        public int? order_type { get; set; }
        public int? wait_for_auth { get; set; }
        public int? suspended_chk { get; set; }
        public int? chk_delivery_xfer { get; set; }
        public DateTime? sent_tm { get; set; }
        public UInt16? minimum_prep_seconds { get; set; }
        public UInt16? expected_drive_minutes { get; set; }
        public UInt16? prep_adjust_seconds { get; set; }
        public DateTime? autofire_tm { get; set; }
        public DateTime? auto_promise_tm { get; set; }
        public DateTime? user_promise_tm { get; set; }
        public DateTime? kds_start_tm { get; set; }
        public DateTime? kds_prep_done_tm { get; set; }
        public DateTime? kds_expo_done_tm { get; set; }
        public int? dispatch_uws_seq { get; set; }
        public DateTime? dispatch_tm { get; set; }
        public int? driver_emp_seq { get; set; }
        public DateTime? undispatch_tm { get; set; }
        public DateTime? lock_dispatch_tm { get; set; }
        public DateTime? approx_delv_tm { get; set; }
        public DateTime? driver_return_tm { get; set; }
        public DateTime? chk_clsd_tm { get; set; }
        public UInt16? distribution_status { get; set; }
        public UInt16? expo_tray_num { get; set; }
        public UInt16? expo_tray_pos { get; set; }
        public int? high_priority { get; set; }
        public int? bev_only { get; set; }
        public int? tbl_seq { get; set; }
        public short? training_status { get; set; }
        public int? cc_tender_on_chk { get; set; }
        public UInt16? early_dt_expo_status { get; set; }
        public int? early_dt_expo_allowed { get; set; }
        public UInt16? drive_thru_order_pos { get; set; }
        public DateTime? first_service_tm { get; set; }
        public int? drive_thru_chk_inserted { get; set; }
        public UInt32? version { get; set; }
        public int? expo_tray_area_seq { get; set; }
        public int? active_dt_win_order { get; set; }
        public int? rvc_seq { get; set; }
        public DateTime? last_update_tm { get; set; }
        public string kds_order_id { get; set; }
        public string opsChkInfoLine01 { get; set; }
        public string opsChkInfoLine02 { get; set; }
        public string opsChkInfoLine03 { get; set; }
        public string opsChkInfoLine04 { get; set; }
        public string opsChkInfoLine05 { get; set; }
        public string opsChkInfoLine06 { get; set; }
        public string opsChkInfoLine07 { get; set; }
        public string opsChkInfoLine08 { get; set; }
        public string opsChkInfoLine09 { get; set; }
        public string opsChkInfoLine10 { get; set; }
        public string opsChkInfoLine11 { get; set; }
        public string opsChkInfoLine12 { get; set; }
        public string opsChkInfoLine13 { get; set; }
        public string opsChkInfoLine14 { get; set; }
        public string opsChkInfoLine15 { get; set; }
        public string opsChkInfoLine16 { get; set; }
        public string gssChkInfoLine01 { get; set; }
        public string gssChkInfoLine02 { get; set; }
        public string gssChkInfoLine03 { get; set; }
        public string gssChkInfoLine04 { get; set; }
        public string gssChkInfoLine05 { get; set; }
        public string gssChkInfoLine06 { get; set; }
        public string gssChkInfoLine07 { get; set; }
        public string gssChkInfoLine08 { get; set; }
        public string gssChkInfoLine09 { get; set; }
        public string gssChkInfoLine10 { get; set; }
        public string gssChkInfoLine11 { get; set; }
        public string gssChkInfoLine12 { get; set; }
        public string gssChkInfoLine13 { get; set; }
        public string gssChkInfoLine14 { get; set; }
        public string gssChkInfoLine15 { get; set; }
        public string gssChkInfoLine16 { get; set; }
        public string customInfoLine01 { get; set; }
        public string customInfoLine02 { get; set; }
        public string customInfoLine03 { get; set; }
        public string customInfoLine04 { get; set; }
        public string customInfoLine05 { get; set; }
        public string customInfoLine06 { get; set; }
        public string customInfoLine07 { get; set; }
        public string customInfoLine08 { get; set; }
        public string customInfoLine09 { get; set; }
        public string customInfoLine10 { get; set; }
        public string customInfoLine11 { get; set; }
        public string customInfoLine12 { get; set; }
        public string customInfoLine13 { get; set; }
        public string customInfoLine14 { get; set; }
        public string customInfoLine15 { get; set; }
        public string customInfoLine16 { get; set; }
        public DateTime? chk_put_away_date_tm { get; set; }
        public DateTime? greeted_tm { get; set; }
    }
}
