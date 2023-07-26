using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class inven_trans_closed_dtl
    {
        public int inven_trans_seq { get; set; }
        public int? inven_trans_batch_seq { get; set; }
        public DateTime trans_date { get; set; }
        public DateTime bus_date { get; set; }
        public short trans_type { get; set; }
        public short? trans_sub_type { get; set; }
        public short trans_class { get; set; }
        public decimal trans_by { get; set; }
        public string dirty { get; set; }
        public int? from_ilcg_seq { get; set; }
        public int? to_ilcg_seq { get; set; }
        public int? ref_seq { get; set; }
        public decimal? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public int? cncy_seq { get; set; }
        public int? rvc_seq { get; set; }
        public int? vndr_seq { get; set; }
    }
}
