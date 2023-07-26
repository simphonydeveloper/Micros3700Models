using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class rcv_ttl
    {
        public int rcv_ttl_seq { get; set; }
        public int store_id { get; set; }
        public int vndr_seq { get; set; }
        public string vndr_itm_id { get; set; }
        public DateTime bus_date { get; set; }
        public DateTime pslp_date { get; set; }
        public DateTime? invc_date { get; set; }
        public string doc_id { get; set; }
        public string invc_id { get; set; }
        public string invc_ref_info { get; set; }
        public int pslp_seq { get; set; }
        public int? invc_seq { get; set; }
        public int ordr_itm_seq { get; set; }
        public int rcv_itm_seq { get; set; }
        public short? stat { get; set; }
        public int? inven_itm_seq { get; set; }
        public int unit_seq { get; set; }
        public int maj_unit_seq { get; set; }
        public decimal qty { get; set; }
        public decimal maj_unit_qty { get; set; }
        public decimal price { get; set; }
        public decimal adj_price { get; set; }
        public decimal invc_price { get; set; }
        public decimal maj_unit_price { get; set; }
        public decimal maj_unit_adj_price { get; set; }
        public decimal maj_unit_invc_price { get; set; }
        public int? acct_seq { get; set; }
        public int ilcg_seq { get; set; }
        public DateTime? last_updated_date { get; set; }
        public short new_rec { get; set; }
    }
}
