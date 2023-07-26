using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cc_batch_xfer_status
    {
        public int batch_seq { get; set; }
        public int settle_attempt_seq { get; set; }
        public int? settle_emp_seq { get; set; }
        public DateTime settle_time { get; set; }
        public string response_text_1 { get; set; }
        public string response_text_2 { get; set; }
        public string response_text_3 { get; set; }
        public string response_text_4 { get; set; }
        public int? prev_settle_cnt { get; set; }
    }
}
