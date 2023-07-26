using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_tax_rate_dtl
    {
        public int tax_rate_seq { get; set; }
        public DateTime effective_from { get; set; }
        public DateTime? effective_to { get; set; }
        public string tax_coll_name { get; set; }
        public string txbl_sls_name { get; set; }
        public string tax_exempt_name { get; set; }
        public string net_sls_name { get; set; }
        public string type { get; set; }
        public decimal? percentage { get; set; }
        public decimal? start_amt { get; set; }
        public int? brkpt_repeat_start { get; set; }
        public int? brkpt_repeat_end { get; set; }
        public string ob_ct01_cmpd_tax_with_gst { get; set; }
        public string ob_ct02_prn_canada_tax_trlr { get; set; }
        public string ob_ct11_thrsh_1_active { get; set; }
        public string ob_ct12_thrsh_1_use_if_zero { get; set; }
        public string ob_ct15_thresh_1_incl_txbl_2 { get; set; }
        public string ob_ct16_thresh_1_incl_txbl_3 { get; set; }
        public string ob_ct17_thresh_1_incl_gst { get; set; }
        public decimal? canada_tax_thresh_1_amt { get; set; }
        public string ob_ct21_thresh_2_active { get; set; }
        public string ob_ct22_thresh_2_use_if_zero { get; set; }
        public string ob_ct25_thresh_2_incl_txbl_2 { get; set; }
        public string ob_ct26_thresh_2_incl_txbl_3 { get; set; }
        public string ob_ct27_thresh_2_incl_gst { get; set; }
        public decimal? canada_tax_thresh_2_amt { get; set; }
        public string ob_rsvd01 { get; set; }
        public string ob_rsvd02 { get; set; }
        public string ob_rsvd03 { get; set; }
        public string ob_rsvd04 { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
