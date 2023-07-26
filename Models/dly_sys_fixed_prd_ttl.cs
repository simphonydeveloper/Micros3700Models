using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class dly_sys_fixed_prd_ttl
    {
        public DateTime business_date { get; set; }
        public int fixed_period_seq { get; set; }
        public int store_id { get; set; }
        public decimal net_sls_ttl { get; set; }
        public decimal? labor_cat_1_reg_hrs { get; set; }
        public decimal? labor_cat_1_ovt_hrs { get; set; }
        public decimal? labor_cat_1_reg_ttl { get; set; }
        public decimal? labor_cat_1_ovt_ttl { get; set; }
        public decimal? labor_cat_2_reg_hrs { get; set; }
        public decimal? labor_cat_2_ovt_hrs { get; set; }
        public decimal? labor_cat_2_reg_ttl { get; set; }
        public decimal? labor_cat_2_ovt_ttl { get; set; }
        public decimal? labor_cat_3_reg_hrs { get; set; }
        public decimal? labor_cat_3_ovt_hrs { get; set; }
        public decimal? labor_cat_3_reg_ttl { get; set; }
        public decimal? labor_cat_3_ovt_ttl { get; set; }
        public decimal? labor_cat_4_reg_hrs { get; set; }
        public decimal? labor_cat_4_ovt_hrs { get; set; }
        public decimal? labor_cat_4_reg_ttl { get; set; }
        public decimal? labor_cat_4_ovt_ttl { get; set; }
        public decimal? non_rvc_labor_cat_1_reg_hrs { get; set; }
        public decimal? non_rvc_labor_cat_1_ovt_hrs { get; set; }
        public decimal? non_rvc_labor_cat_1_reg_ttl { get; set; }
        public decimal? non_rvc_labor_cat_1_ovt_ttl { get; set; }
        public decimal? non_rvc_labor_cat_2_reg_hrs { get; set; }
        public decimal? non_rvc_labor_cat_2_ovt_hrs { get; set; }
        public decimal? non_rvc_labor_cat_2_reg_ttl { get; set; }
        public decimal? non_rvc_labor_cat_2_ovt_ttl { get; set; }
        public decimal? non_rvc_labor_cat_3_reg_hrs { get; set; }
        public decimal? non_rvc_labor_cat_3_ovt_hrs { get; set; }
        public decimal? non_rvc_labor_cat_3_reg_ttl { get; set; }
        public decimal? non_rvc_labor_cat_3_ovt_ttl { get; set; }
        public decimal? non_rvc_labor_cat_4_reg_hrs { get; set; }
        public decimal? non_rvc_labor_cat_4_ovt_hrs { get; set; }
        public decimal? non_rvc_labor_cat_4_reg_ttl { get; set; }
        public decimal? non_rvc_labor_cat_4_ovt_ttl { get; set; }
        public int em_ttl_repl_seq { get; set; }
        public DateTime? mylabor_sync_tm { get; set; }
    }
}
