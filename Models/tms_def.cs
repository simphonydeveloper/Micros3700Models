using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class tms_def
    {
        public int tms_seq { get; set; }
        public UInt32? min_confirmation_number { get; set; }
        public UInt32? max_confirmation_number { get; set; }
        public short? days_to_retain_tbl_request { get; set; }
        public short? tbl_closed_icon_id { get; set; }
        public short? tbl_reserved_icon_id { get; set; }
        public short? tbl_seated_icon_id { get; set; }
        public short? tbl_chk_printed_icon_id { get; set; }
        public short? tbl_payment_complete_icon_id { get; set; }
        public short? tbl_dirty_icon_id { get; set; }
        public string ob_enabled { get; set; }
        public short? rpt_large_party_limit { get; set; }
        public short? tbl_selected_icon_id { get; set; }
        public short? tbl_highlighted_icon_id { get; set; }
        public short? tbl_suggested_icon_id { get; set; }
        public short? tbl_joined_parent_icon_id { get; set; }
        public short? tbl_joined_child_icon_id { get; set; }
        public short? wait_alert_threshold { get; set; }
        public int? wait_alert_threshold_color { get; set; }
        public string alert_manager_server { get; set; }
        public int? alert_manager_port { get; set; }
        public short? paid_in_full_threshold { get; set; }
        public string ob_force_reservation_auth { get; set; }
        public string ob_enable_show_next_tbl_server { get; set; }
        public string ob_display_server_name { get; set; }
        public short? wait_quote_interval { get; set; }
        public string ob_show_next_tbl_hm_only { get; set; }
        public string ob_show_emp_tbl_lns_hm_only { get; set; }
    }
}
