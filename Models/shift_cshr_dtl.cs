using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class shift_cshr_dtl
    {
        public int store_id { get; set; }
        public int cshr_ttl_seq { get; set; }
        public int shift_seq { get; set; }
        public DateTime shift_start_time { get; set; }
        public DateTime? shift_end_time { get; set; }
        public string ob_rsvd01 { get; set; }
    }
}
