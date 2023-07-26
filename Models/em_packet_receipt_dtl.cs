using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_packet_receipt_dtl
    {
        public int packet_seq { get; set; }
        public string packet_type { get; set; }
    }
}
