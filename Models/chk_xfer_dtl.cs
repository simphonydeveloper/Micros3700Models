using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class chk_xfer_dtl
    {
        public int trans_seq { get; set; }
        public int rvc_seq { get; set; }
        public int emp_seq { get; set; }
        public int chk_seq { get; set; }
        public int? cshr_ttl_seq { get; set; }
        public int? cshr_ttl_shift_seq { get; set; }
        public string xfer_type { get; set; }
        public decimal xfer_ttl { get; set; }
        public decimal amt_due_ttl { get; set; }
    }
}
