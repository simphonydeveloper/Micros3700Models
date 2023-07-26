using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class ordr_itm_dtl
    {
        public int ordr_itm_seq { get; set; }
        public int ordr_seq { get; set; }
        public int? acct_seq { get; set; }
        public int? ilcg_seq { get; set; }
        public int? price_ovrde_rsn_seq { get; set; }
        public int? inven_itm_seq { get; set; }
        public double? ordr_qty { get; set; }
        public int? ordr_unit_seq { get; set; }
        public double? ordr_price { get; set; }
        public double? adj_price { get; set; }
        public string vndr_ovrde { get; set; }
        public int? vndr_ovrde_rsn_seq { get; set; }
        public double qty_rcv { get; set; }
        public string rcv_check { get; set; }
        public string cmnt_ln { get; set; }
        public short? stat { get; set; }
        public int? po_ovrde_rsn_seq { get; set; }
        public string othr_desc { get; set; }
        public int? last_updated_by { get; set; }
        public double? adjmt { get; set; }
        public DateTime? last_updated_date { get; set; }
        public int? cncy_seq { get; set; }
        public double? ordr_price_base { get; set; }
        public string ob_rtn { get; set; }
        public int? ilcg_par_sched_dtl_seq { get; set; }
    }
}
