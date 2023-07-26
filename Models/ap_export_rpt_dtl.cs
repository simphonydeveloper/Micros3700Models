using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class ap_export_rpt_dtl
    {
        public int? bacth_seq { get; set; }
        public int? vndr_obj_num { get; set; }
        public string vndr_name { get; set; }
        public string vndr_ap_acct_id { get; set; }
        public string doc_id { get; set; }
        public double? doc_ttl { get; set; }
        public DateTime? doc_date { get; set; }
        public string dtl_type { get; set; }
        public int? gl_acct_id { get; set; }
        public double? gl_acct_amt { get; set; }
        public string gl_acct_ref_info { get; set; }
        public int? invc_seq { get; set; }
        public double? invc_diff_ttl { get; set; }
        public double? reconcld_ttl { get; set; }
        public double? itm_ttl { get; set; }
        public short? num_net_days { get; set; }
        public int? aprvd_by { get; set; }
        public DateTime? aprvd_date { get; set; }
    }
}
