using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cshr_ttl_status
    {
        public int cshr_ttl_seq { get; set; }
        public int shift_seq { get; set; }
        public DateTime? prev_shift_end_time { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
