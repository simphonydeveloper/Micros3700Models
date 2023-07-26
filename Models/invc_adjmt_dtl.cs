using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class invc_adjmt_dtl
    {
        public int invc_adjmt_dtl_seq { get; set; }
        public int invc_seq { get; set; }
        public int adjmt_seq { get; set; }
        public double? pct { get; set; }
        public double? amt { get; set; }
        public int? precedence_ordr { get; set; }
        public int? acct_seq { get; set; }
        public short? adjmt_type { get; set; }
        public short? alloc_mthd { get; set; }
        public string ob_include { get; set; }
        public string ob_include_cost { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public double? amt_base { get; set; }
    }
}
