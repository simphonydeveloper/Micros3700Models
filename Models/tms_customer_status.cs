using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class tms_customer_status
    {
        public int customer_seq { get; set; }
        public short? reservation_cancellations { get; set; }
        public short? reservation_no_shows { get; set; }
        public string ob_vip { get; set; }
        public string text_detail { get; set; }
    }
}
