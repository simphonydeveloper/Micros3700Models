using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class invc_dtl
    {
        public int invc_seq { get; set; }
        public int? vndr_seq { get; set; }
        public string invc_doc_id { get; set; }
        public DateTime invc_date { get; set; }
        public double? invc_ttl { get; set; }
        public double? reconcld_ttl { get; set; }
        public double? invc_diff_ttl { get; set; }
        public string ref_info { get; set; }
        public short? stat { get; set; }
        public double? itm_ttl { get; set; }
        public short? pymnt_term_ovrde { get; set; }
        public short? num_net_day { get; set; }
        public int? aprvd_by { get; set; }
        public DateTime? aprvd_date { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public double? reconcld_base { get; set; }
        public double? othr_adjmt { get; set; }
        public double? pslp_ttl { get; set; }
        public double? invc_ttl_base { get; set; }
        public double? itm_ttl_base { get; set; }
        public double? invc_diff_ttl_base { get; set; }
        public double? othr_adjmt_base { get; set; }
        public double? pslp_ttl_base { get; set; }
        public double? reconcld_ttl_base { get; set; }
        public string ref_info_2 { get; set; }
        public int? ref_num { get; set; }
    }
}
