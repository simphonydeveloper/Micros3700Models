using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cc_auth_dtl
    {
        public int trans_seq { get; set; }
        public int dtl_seq { get; set; }
        public int tmed_seq { get; set; }
        public string ob_manual_entry { get; set; }
        public decimal base_amount { get; set; }
        public decimal tip_amount { get; set; }
        public string track_1_data { get; set; }
        public string track_2_data { get; set; }
        public string cc_acct_num { get; set; }
        public string expiration_date { get; set; }
        public string customer_name { get; set; }
        public string ob_manual_auth { get; set; }
        public string alternate_tender_name { get; set; }
        public string response_type { get; set; }
        public string start_date { get; set; }
        public string issue_number { get; set; }
        public string auth_code { get; set; }
        public string driver_data_1 { get; set; }
        public string driver_data_2 { get; set; }
        public string driver_data_3 { get; set; }
        public string ob_print_driver_data_1 { get; set; }
        public string ob_print_driver_data_2 { get; set; }
        public string ob_print_driver_data_3 { get; set; }
        public string ob_demo_driver { get; set; }
        public string ob_no_prn_voucher { get; set; }
        public string ob_omit_from_floor_limits { get; set; }
        public string ob_do_not_batch { get; set; }
        public string prompt_ans_at_keyed_ca { get; set; }
        public string prompt_card_present_ans { get; set; }
        public int? encrypt_value_seq { get; set; }
        public int? cc_vchr_custom_seq { get; set; }
        public string acct_alias { get; set; }
        public string ob_keyed_acct { get; set; }
        public byte[] eAcctNum { get; set; }
        public byte[] eTrack2 { get; set; }
        public byte[] eCustName { get; set; }
        public byte[] eExpDate { get; set; }
        public byte[] hAcctNum { get; set; }
        public string ob_cobrand_overridden { get; set; }
        public decimal? avail_balance { get; set; }
        public string ob_auto_offline_auth { get; set; }
        public string ob_encoded_acct_num { get; set; }
        public short? acct_data_src { get; set; }
        public string cc_acct_num_ex { get; set; }
        public string ob_reversed { get; set; }
    }
}
