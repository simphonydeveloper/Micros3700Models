using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class ap_export_entry_dtl
    {
        public int ap_export_batch_seq { get; set; }
        public int ap_export_entry_seq { get; set; }
        public string dtl_type { get; set; }
        public int vndr_seq { get; set; }
        public string doc_id { get; set; }
        public DateTime doc_date { get; set; }
        public double doc_ttl { get; set; }
        public short? pymnt_term { get; set; }
    }
}
