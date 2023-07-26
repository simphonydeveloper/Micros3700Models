using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class tms_tbl_request_dtl
    {
        public int tbl_request_dtl_seq { get; set; }
        public DateTime? creation_date { get; set; }
        public int? emp_seq { get; set; }
        public int? rvc_seq { get; set; }
        public short? reservation_cov_cnt { get; set; }
        public string ob_pending_approval { get; set; }
        public int? approved_by { get; set; }
        public DateTime? approved_date { get; set; }
        public int? customer_seq { get; set; }
        public DateTime? reservation_date { get; set; }
        public DateTime? cancel_date { get; set; }
        public int? reason_seq { get; set; }
        public DateTime? no_show_date { get; set; }
        public DateTime? greeted_date { get; set; }
        public short? cov_cnt { get; set; }
        public string guest_name { get; set; }
        public string phone_number { get; set; }
        public string ob_VIP { get; set; }
        public short? wait_quote { get; set; }
        public short? pager_number { get; set; }
        public short? page_time { get; set; }
        public short? abandon_time { get; set; }
        public short? seated_time { get; set; }
        public int? chk_seq { get; set; }
        public string text_detail { get; set; }
        public short? estimated_wait { get; set; }
        public int? tbl_seq { get; set; }
        public UInt32? confirmation_number { get; set; }
        public string referral_notes { get; set; }
        public string request_method { get; set; }
        public string request_method_ref { get; set; }
        public DateTime? lock_time { get; set; }
        public string ob_user_tbl_suggest { get; set; }
        public short? suggest_position { get; set; }
    }
}
