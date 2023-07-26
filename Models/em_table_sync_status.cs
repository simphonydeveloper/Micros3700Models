using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_table_sync_status
    {
        public int store_id { get; set; }
        public int em_table_reg_seq { get; set; }
        public string sent_status { get; set; }
        public string sent_error_txt { get; set; }
        public DateTime? sent_datetime { get; set; }
        public int? sent_msg_id { get; set; }
        public string rcv_status { get; set; }
        public string rcv_error_txt { get; set; }
        public DateTime? rcv_datetime { get; set; }
        public int? rcv_msg_id { get; set; }
    }
}
