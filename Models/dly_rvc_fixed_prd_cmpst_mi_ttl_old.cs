using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class dly_rvc_fixed_prd_cmpst_mi_ttl_old
    {
        public DateTime business_date { get; set; }
        public int store_id { get; set; }
        public int rvc_seq { get; set; }
        public int fixed_period_seq { get; set; }
        public int mi_seq { get; set; }
        public int price_1_sls_cnt { get; set; }
        public int price_1_rtn_cnt { get; set; }
        public decimal price_1_dsc_ttl { get; set; }
        public decimal price_1_composite_dsc_ttl { get; set; }
        public decimal price_1_sls_ttl { get; set; }
        public decimal price_1_composite_sls_ttl { get; set; }
        public decimal? price_1_cost_ttl { get; set; }
        public decimal? price_1_composite_cost_ttl { get; set; }
        public decimal? price_1_vat_ttl { get; set; }
        public decimal? price_1_composite_vat_ttl { get; set; }
        public int price_2_sls_cnt { get; set; }
        public int price_2_rtn_cnt { get; set; }
        public decimal price_2_dsc_ttl { get; set; }
        public decimal price_2_composite_dsc_ttl { get; set; }
        public decimal price_2_sls_ttl { get; set; }
        public decimal price_2_composite_sls_ttl { get; set; }
        public decimal? price_2_cost_ttl { get; set; }
        public decimal? price_2_composite_cost_ttl { get; set; }
        public decimal? price_2_vat_ttl { get; set; }
        public decimal? price_2_composite_vat_ttl { get; set; }
        public int price_3_sls_cnt { get; set; }
        public int price_3_rtn_cnt { get; set; }
        public decimal price_3_dsc_ttl { get; set; }
        public decimal price_3_composite_dsc_ttl { get; set; }
        public decimal price_3_sls_ttl { get; set; }
        public decimal price_3_composite_sls_ttl { get; set; }
        public decimal? price_3_cost_ttl { get; set; }
        public decimal? price_3_composite_cost_ttl { get; set; }
        public decimal? price_3_vat_ttl { get; set; }
        public decimal? price_3_composite_vat_ttl { get; set; }
        public int price_4_sls_cnt { get; set; }
        public int price_4_rtn_cnt { get; set; }
        public decimal price_4_dsc_ttl { get; set; }
        public decimal price_4_composite_dsc_ttl { get; set; }
        public decimal price_4_sls_ttl { get; set; }
        public decimal price_4_composite_sls_ttl { get; set; }
        public decimal? price_4_cost_ttl { get; set; }
        public decimal? price_4_composite_cost_ttl { get; set; }
        public decimal? price_4_vat_ttl { get; set; }
        public decimal? price_4_composite_vat_ttl { get; set; }
        public decimal? weight_ttl { get; set; }
        public int em_ttl_repl_seq { get; set; }
    }
}
