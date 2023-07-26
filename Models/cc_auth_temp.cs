using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cc_auth_temp
    {
        public int cc_auth_seq { get; set; }
        public int cc_item_dtl_seq { get; set; }
        public int cc_batch_seq { get; set; }
        public string auth_code { get; set; }
        public decimal? end_base_amount { get; set; }
        public decimal? end_tip_amount { get; set; }
        public string driver_data_1 { get; set; }
        public string driver_data_2 { get; set; }
        public string driver_data_3 { get; set; }
        public DateTime? auth_date_time { get; set; }
        public string response_type { get; set; }
        public string ob_print_data_1 { get; set; }
        public string ob_print_data_2 { get; set; }
        public string ob_print_data_3 { get; set; }
        public string ob_demo_driver { get; set; }
        public string ob_manual_auth { get; set; }
        public string ob_void { get; set; }
        public string ob_item_read { get; set; }
    }
}
