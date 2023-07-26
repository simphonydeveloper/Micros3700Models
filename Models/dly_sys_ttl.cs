using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class dly_sys_ttl
    {
        public DateTime business_date { get; set; }
        public int store_id { get; set; }
        public decimal net_sls_ttl { get; set; }
        public int rtn_cnt { get; set; }
        public decimal rtn_ttl { get; set; }
        public int void_cnt { get; set; }
        public decimal void_ttl { get; set; }
        public decimal item_dsc_ttl { get; set; }
        public decimal sttl_dsc_ttl { get; set; }
        public decimal svc_ttl { get; set; }
        public decimal tax_coll_ttl { get; set; }
        public decimal credit_ttl { get; set; }
        public decimal rounding_ttl { get; set; }
        public decimal change_grand_ttl { get; set; }
        public decimal non_txbl_ttl { get; set; }
        public int cancel_cnt { get; set; }
        public decimal cancel_ttl { get; set; }
        public int mgr_void_cnt { get; set; }
        public decimal mgr_void_ttl { get; set; }
        public int error_correct_cnt { get; set; }
        public decimal error_correct_ttl { get; set; }
        public int chk_carry_over_cnt { get; set; }
        public decimal chk_carry_over_ttl { get; set; }
        public int chk_begun_cnt { get; set; }
        public decimal chk_begun_ttl { get; set; }
        public int chk_paid_cnt { get; set; }
        public decimal chk_paid_ttl { get; set; }
        public decimal gross_rcpts_ttl { get; set; }
        public decimal chgd_rcpts_ttl { get; set; }
        public decimal chgd_tips_ttl { get; set; }
        public decimal tip_svc_ttl { get; set; }
        public decimal tips_paid_ttl { get; set; }
        public decimal tips_decl_ttl { get; set; }
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
        public decimal grand_ttl { get; set; }
        public byte[] grand_ttl_raw { get; set; }
        public decimal training_ttl { get; set; }
        public DateTime? business_date_start_time { get; set; }
        public DateTime? business_date_end_time { get; set; }
        public DateTime? business_date_start_time_gmt { get; set; }
        public DateTime? business_date_end_time_gmt { get; set; }
        public int em_ttl_repl_seq { get; set; }
        public decimal? ind_tips_paid_ttl { get; set; }
        public DateTime? mylabor_sync_tm { get; set; }
    }
}
