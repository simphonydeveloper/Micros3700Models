using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class ap_export_entry_addl_dtl
    {
        public int? ap_export_batch_seq { get; set; }
        public int? ap_export_entry_seq { get; set; }
        public int? invc_seq { get; set; }
        public double? invc_diff_ttl { get; set; }
        public double? reconcld_ttl { get; set; }
        public double? itm_ttl { get; set; }
        public short? num_net_days { get; set; }
        public int? aprvd_by { get; set; }
        public DateTime? aprvd_date { get; set; }
    }
}
