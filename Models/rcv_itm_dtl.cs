using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class rcv_itm_dtl
    {
        public int ordr_itm_seq { get; set; }
        public int rcv_itm_seq { get; set; }
        public int ordr_seq { get; set; }
        public int? inven_trans_seq { get; set; }
        public int? ilcg_seq { get; set; }
        public int? pslp_seq { get; set; }
        public int? reason_seq { get; set; }
        public double? qty { get; set; }
        public int? unit_seq { get; set; }
        public double? itm_price { get; set; }
        public double? adj_price { get; set; }
        public short? rcv_itm_stat { get; set; }
        public string vndr_doc_info { get; set; }
        public double? adjmt { get; set; }
        public decimal? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public double? incl_adjmt_amt_base { get; set; }
        public double? excl_adjmt_amt_base { get; set; }
        public double? adjmt_base { get; set; }
        public double? adjmt_cost_amt_base { get; set; }
        public double? incl_adjmt_amt { get; set; }
        public double? excl_adjmt_amt { get; set; }
        public double? adjmt_cost_amt { get; set; }
        public int? cncy_seq { get; set; }
        public double? itm_price_base { get; set; }
        public double? rcv_ttl_base { get; set; }
        public double? adj_price_base { get; set; }
        public double? rcv_ttl { get; set; }
        public double? adj_cost { get; set; }
        public double? adj_cost_base { get; set; }
        public int? closed_prd_trans_seq { get; set; }
    }
}
