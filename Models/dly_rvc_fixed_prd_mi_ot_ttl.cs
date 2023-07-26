using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class dly_rvc_fixed_prd_mi_ot_ttl
    {
        public int store_id { get; set; }
        public DateTime business_date { get; set; }
        public int rvc_seq { get; set; }
        public int fixed_period_seq { get; set; }
        public int mi_seq { get; set; }
        public int order_type_seq { get; set; }
        public short price_lvl { get; set; }
        public int? sls_cnt { get; set; }
        public int? rtn_cnt { get; set; }
        public decimal? weight_ttl { get; set; }
        public decimal? sls_ttl { get; set; }
        public decimal? vat_ttl { get; set; }
        public decimal? vat_ttl_ex { get; set; }
        public decimal? dsc_ttl { get; set; }
        public decimal? dsc_vat_ttl { get; set; }
        public decimal? dsc_vat_ttl_ex { get; set; }
        public int em_ttl_repl_seq { get; set; }
        public decimal? suppressed_sls_ttl { get; set; }
    }
}
