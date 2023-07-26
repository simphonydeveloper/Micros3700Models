using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class ap_export_acct_dtl
    {
        public int ap_export_batch_seq { get; set; }
        public int ap_export_entry_seq { get; set; }
        public int ap_export_acct_dtl_seq { get; set; }
        public int? acct_seq { get; set; }
        public string acct_dtl_type { get; set; }
        public double amt { get; set; }
        public string ref_info { get; set; }
    }
}
