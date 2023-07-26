using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cc_item_dtl_temp
    {
        public int cc_item_dtl_seq { get; set; }
        public int cc_batch_seq { get; set; }
        public DateTime? date_time { get; set; }
        public string track2_data { get; set; }
        public string cc_acct_num { get; set; }
        public string alternate_tender_name { get; set; }
        public short? num_auths { get; set; }
        public int? tmed_seq { get; set; }
        public int? rvc_seq { get; set; }
        public decimal? end_total_pay_amount { get; set; }
        public decimal? end_tip_pay_amount { get; set; }
        public int? chk_emp_seq { get; set; }
        public int? trans_emp_seq { get; set; }
        public short? chk_num { get; set; }
        public string ob_immed_pymnt { get; set; }
        public string ob_manual_entry { get; set; }
        public string issue_number { get; set; }
        public string start_date { get; set; }
        public string expiration_date { get; set; }
        public int? encrypt_value_seq { get; set; }
    }
}
