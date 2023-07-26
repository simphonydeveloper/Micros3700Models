using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class chk_event_dtl
    {
        public int chk_event_dtl_seq { get; set; }
        public int? chk_seq { get; set; }
        public int chk_event_type { get; set; }
        public DateTime chk_event_tm { get; set; }
    }
}
