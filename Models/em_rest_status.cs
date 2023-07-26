using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_rest_status
    {
        public int store_id { get; set; }
        public int? em_last_rcv_msg_id { get; set; }
        public int? em_next_sent_msg_id { get; set; }
        public DateTime? pending_price_last_updated { get; set; }
    }
}
