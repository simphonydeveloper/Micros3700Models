using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class tms_rvc_def
    {
        public int rvc_seq { get; set; }
        public int? obj_num { get; set; }
        public string name { get; set; }
        public string ob_allow_reservation { get; set; }
        public string ob_allow_call_ahead { get; set; }
        public short? min_reservation_notice { get; set; }
        public short? max_reservation_notice { get; set; }
        public short? reservation_to_waitlist_delay { get; set; }
        public short? auto_abandon_waitlist_delay { get; set; }
        public short? course_turn_time_impact { get; set; }
        public short? historic_turn_time_impact { get; set; }
        public short? recent_turn_time_impact { get; set; }
        public short? target_turn_time_impact { get; set; }
        public short? tbl_turn_time_impact { get; set; }
        public short? tbl_unavailable_wgt { get; set; }
        public short? tbl_unclean_wgt { get; set; }
        public short? per_unused_seat_wgt { get; set; }
        public short? per_min_waiting_wgt { get; set; }
        public short? per_min_waiting_past_quote_wgt { get; set; }
        public short? reservation_wgt { get; set; }
        public short? per_min_waiting_reservation_wgt { get; set; }
        public short? per_day_reservation_notice_wgt { get; set; }
        public short? VIP_wgt { get; set; }
        public short? per_min_waiting_VIP_wgt { get; set; }
        public short? per_server_cov_wgt { get; set; }
        public short? per_server_chk_wgt { get; set; }
        public short? per_min_from_last_chk_wgt { get; set; }
        public short? recent_history_clsd_chk_cnt { get; set; }
        public short? recent_history_clsd_chk_min { get; set; }
        public string ob_set_check_id_to_guest_name { get; set; }
        public string ob_print_waitlist_chit { get; set; }
        public string ob_print_server_guest_chit { get; set; }
        public short? greeted_wgt { get; set; }
        public string ob_ignore_tms_cvr_cnt { get; set; }
        public string ob_cls_unassign_tbl_act_layout { get; set; }
        public int? last_active_seat_sect_layout { get; set; }
        public int? last_seat_sect_layout_mod_cnt { get; set; }
        public int? server_effic_rating_wgt { get; set; }
        public short? dflt_server_unavailable_minutes { get; set; }
        public string ob_req_tbl_during_seating { get; set; }
    }
}
