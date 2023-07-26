using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class dtl
    {
        public int trans_seq { get; set; }
        public int dtl_seq { get; set; }
        public string dtl_type { get; set; }
        public string ob_dtl06_ref_dtl_follows { get; set; }
        public string ob_dtl05_void_flag { get; set; }
        public string ob_error_correct { get; set; }
        public string ob_item_shared { get; set; }
        public byte[] dtl_status { get; set; }
        public int? reason_seq { get; set; }
        public int? auth_emp { get; set; }
        public short seat { get; set; }
        public DateTime date_time { get; set; }
        public byte[] date_time_raw { get; set; }
        public string record_type { get; set; }
        public short dtl_index { get; set; }
        public short? shared_numerator { get; set; }
        public short? shared_denominator { get; set; }
        public decimal? inclusive_tax_ttl { get; set; }
        public short chk_cnt { get; set; }
        public decimal chk_ttl { get; set; }
        public short rpt_cnt { get; set; }
        public decimal rpt_ttl { get; set; }
        public decimal? comm_ttl { get; set; }
        public DateTime? autofire_date_time { get; set; }
        public int event_priority { get; set; }
        public int? dtl_id { get; set; }
        public byte[] autofire_time_raw { get; set; }
        public int? external_seq { get; set; }
        public int? external_type { get; set; }
        public string void_type { get; set; }
        public string dtl_name { get; set; }
        public decimal? rpt_inclusive_tax_ttl { get; set; }
        public short? active_taxes { get; set; }
        public int? order_type_seq { get; set; }
        public decimal? rpt_inclusive_tax_ttl_ex { get; set; }
        public int? orig_rvc_seq { get; set; }
        public decimal? suppressed_rpt_ttl { get; set; }
        public int? origin_uws_seq { get; set; }
        public DateTime? trans_begin_tm { get; set; }
        public int? extensibility_id { get; set; }
    }
}
