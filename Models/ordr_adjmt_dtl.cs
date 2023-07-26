using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class ordr_adjmt_dtl
    {
        public int ordr_adjmt_seq { get; set; }
        public int ordr_seq { get; set; }
        public int? adjmt_seq { get; set; }
        public double? amt { get; set; }
        public double? pct { get; set; }
        public string ob_include { get; set; }
        public short? alloc_mthd { get; set; }
        public string ob_inven_itm_adjmt { get; set; }
        public short adjmt_type { get; set; }
        public int? precedence_ordr { get; set; }
        public int? acct_seq { get; set; }
        public string ob_rcvd { get; set; }
        public string cmnt_ln { get; set; }
        public decimal? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
