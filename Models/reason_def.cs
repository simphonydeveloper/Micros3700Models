using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class reason_def
    {
        public int reason_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public string ob_rsn01_use_with_voids { get; set; }
        public string ob_rsn02_use_with_rtns { get; set; }
        public string ob_rsn03_use_with_tm_clk_adj { get; set; }
        public string ob_use_with_wste { get; set; }
        public string ob_use_with_po_mod { get; set; }
        public string ob_use_with_po_var { get; set; }
        public string ob_use_with_vndr_ovrde { get; set; }
        public string ob_use_with_price_ovrde { get; set; }
        public string ob_use_with_hr_inactive { get; set; }
        public string ob_use_with_hr_termination { get; set; }
        public string ob_use_with_hr_request { get; set; }
        public string ob_rsvd01 { get; set; }
        public string ob_rsvd02 { get; set; }
        public string ob_rsvd03 { get; set; }
        public string ob_rsvd04 { get; set; }
        public string ob_rsvd05 { get; set; }
        public int? time_allowed { get; set; }
        public string reference_code { get; set; }
        public string description { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public string ob_use_with_pay_change { get; set; }
        public string EM_GUID { get; set; }
        public string ob_use_with_tms { get; set; }
        public string action_type { get; set; }
        public string action_reason_code { get; set; }
        public string ob_use_with_early_end_break { get; set; }
        public string ob_use_with_in_after_recent_out { get; set; }
        public string ob_recent_clkout_was_break { get; set; }
        public string ob_break_should_be_paid { get; set; }
    }
}
