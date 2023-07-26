using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cc_batch_ca_dtl
    {
        public int batch_seq { get; set; }
        public int batch_item_seq { get; set; }
        public int batch_ca_seq { get; set; }
        public string response_type { get; set; }
        public decimal base_amount { get; set; }
        public decimal tip_amount { get; set; }
        public string auth_code { get; set; }
        public DateTime auth_date_time { get; set; }
        public int? chk_emp_seq { get; set; }
        public int uws_seq { get; set; }
        public int rvc_seq { get; set; }
        public string ob_manual_auth { get; set; }
        public string ob_void_flag { get; set; }
        public string ob_demo_driver { get; set; }
        public string ob_print_driver_data_1 { get; set; }
        public string ob_print_driver_data_2 { get; set; }
        public string ob_print_driver_data_3 { get; set; }
        public string prompt_ans_at_keyed_ca { get; set; }
        public string driver_data_1 { get; set; }
        public string driver_data_2 { get; set; }
        public string driver_data_3 { get; set; }
        public string authed_below_floor_limit { get; set; }
        public string acct_alias { get; set; }
        public string ob_auto_offline_auth { get; set; }
        public short? acct_data_src { get; set; }
    }
}
