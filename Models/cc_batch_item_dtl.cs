using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cc_batch_item_dtl
    {
        public int batch_seq { get; set; }
        public int batch_item_seq { get; set; }
        public string track_2_data { get; set; }
        public string track_1_data { get; set; }
        public string cc_acct_num { get; set; }
        public string expiration_date { get; set; }
        public string ob_manual_entry { get; set; }
        public string start_date { get; set; }
        public string issue_number { get; set; }
        public string customer_name { get; set; }
        public string alternate_tender_name { get; set; }
        public int tmed_seq { get; set; }
        public int uws_seq { get; set; }
        public int rvc_seq { get; set; }
        public int? chk_emp_seq { get; set; }
        public short? chk_num { get; set; }
        public DateTime date_time { get; set; }
        public decimal base_ttl { get; set; }
        public decimal charge_tip_ttl { get; set; }
        public short num_auths { get; set; }
        public string ob_immed_pymnt { get; set; }
        public string ob_settled { get; set; }
        public string omitted_by { get; set; }
        public string ob_is_debit { get; set; }
        public decimal? cashback_ttl { get; set; }
        public int? encrypt_value_seq { get; set; }
        public string ob_acct_aliased { get; set; }
        public byte[] eAcctNum { get; set; }
        public byte[] eExpDate { get; set; }
        public byte[] eTrack2 { get; set; }
        public byte[] eCustName { get; set; }
        public string ob_keyed_acct { get; set; }
        public string ob_cobrand_overridden { get; set; }
        public string ob_encoded_acct_num { get; set; }
    }
}
