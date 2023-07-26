using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class pslp_dtl
    {
        public int pslp_seq { get; set; }
        public int? invc_seq { get; set; }
        public string pslp_doc_id { get; set; }
        public DateTime pslp_date { get; set; }
        public double? pslp_ttl { get; set; }
        public short stat { get; set; }
        public DateTime rcv_date { get; set; }
        public decimal rcv_by { get; set; }
        public string faux { get; set; }
        public double? itm_adjmt { get; set; }
        public double? othr_adjmt { get; set; }
        public double? pslp_reconcld_ttl { get; set; }
        public double? itm_ttl { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public double? itm_adjmt_base { get; set; }
        public double? itm_ttl_base { get; set; }
        public double? othr_adjmt_base { get; set; }
        public double? pslp_reconcld_ttl_base { get; set; }
        public double? pslp_ttl_base { get; set; }
        public long? multi_user_access_seq { get; set; }
    }
}
