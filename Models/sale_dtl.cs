using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class sale_dtl
    {
        public int trans_seq { get; set; }
        public int order_type_seq { get; set; }
        public decimal sls_itmzr_01 { get; set; }
        public decimal sls_itmzr_02 { get; set; }
        public decimal sls_itmzr_03 { get; set; }
        public decimal sls_itmzr_04 { get; set; }
        public decimal sls_itmzr_05 { get; set; }
        public decimal sls_itmzr_06 { get; set; }
        public decimal sls_itmzr_07 { get; set; }
        public decimal sls_itmzr_08 { get; set; }
        public decimal txbl_sls_itmzr_01 { get; set; }
        public decimal txbl_sls_itmzr_02 { get; set; }
        public decimal txbl_sls_itmzr_03 { get; set; }
        public decimal txbl_sls_itmzr_04 { get; set; }
        public decimal txbl_sls_itmzr_05 { get; set; }
        public decimal txbl_sls_itmzr_06 { get; set; }
        public decimal txbl_sls_itmzr_07 { get; set; }
        public decimal txbl_sls_itmzr_08 { get; set; }
        public decimal tax_exempt_sls_itmzr_01 { get; set; }
        public decimal tax_exempt_sls_itmzr_02 { get; set; }
        public decimal tax_exempt_sls_itmzr_03 { get; set; }
        public decimal tax_exempt_sls_itmzr_04 { get; set; }
        public decimal tax_exempt_sls_itmzr_05 { get; set; }
        public decimal tax_exempt_sls_itmzr_06 { get; set; }
        public decimal tax_exempt_sls_itmzr_07 { get; set; }
        public decimal tax_exempt_sls_itmzr_08 { get; set; }
        public decimal tax_itmzr_01 { get; set; }
        public decimal tax_itmzr_02 { get; set; }
        public decimal tax_itmzr_03 { get; set; }
        public decimal tax_itmzr_04 { get; set; }
        public decimal tax_itmzr_05 { get; set; }
        public decimal tax_itmzr_06 { get; set; }
        public decimal tax_itmzr_07 { get; set; }
        public decimal tax_itmzr_08 { get; set; }
        public decimal auto_svc_ttl { get; set; }
        public decimal other_svc_ttl { get; set; }
        public decimal net_sls_ttl { get; set; }
        public short rtn_cnt { get; set; }
        public decimal rtn_ttl { get; set; }
        public short void_cnt { get; set; }
        public decimal void_ttl { get; set; }
        public decimal item_dsc_ttl { get; set; }
        public decimal sttl_dsc_ttl { get; set; }
        public decimal tax_coll_ttl { get; set; }
        public decimal credit_ttl { get; set; }
        public decimal non_txbl_ttl { get; set; }
        public decimal rounding_ttl { get; set; }
        public decimal change_grand_ttl { get; set; }
        public decimal pymnt_ttl { get; set; }
        public decimal training_ttl { get; set; }
        public short cov_cnt { get; set; }
        public short chk_begun_cnt { get; set; }
        public short chk_paid_cnt { get; set; }
        public short tbl_turn_cnt { get; set; }
        public int tbl_dine_time { get; set; }
        public string ob_sl01_chk_prntd { get; set; }
        public decimal gross_rcpts { get; set; }
        public decimal chg_rcpts_ttl { get; set; }
        public decimal charged_tip_ttl { get; set; }
        public decimal tip_svc_chg_ttl { get; set; }
        public short mgr_void_cnt { get; set; }
        public decimal mgr_void_ttl { get; set; }
        public short error_correct_cnt { get; set; }
        public decimal error_correct_ttl { get; set; }
        public string ob_order_type_changed { get; set; }
        public decimal cur_ot_net_sls_ttl { get; set; }
        public short cur_ot_cov_cnt { get; set; }
        public short cur_ot_chk_cnt { get; set; }
        public short cur_ot_tbl_turn_cnt { get; set; }
        public int cur_ot_tbl_dine_time { get; set; }
        public decimal prev_ot_net_sls_ttl { get; set; }
        public short prev_ot_cov_cnt { get; set; }
        public short prev_ot_chk_cnt { get; set; }
        public short prev_ot_tbl_turn_cnt { get; set; }
        public int prev_ot_tbl_dine_time { get; set; }
        public int? prev_order_type_seq { get; set; }
        public decimal? amt_due_ttl { get; set; }
        public decimal? incl_tax_by_chk_itmzr_01 { get; set; }
        public decimal? incl_tax_by_chk_itmzr_02 { get; set; }
        public decimal? incl_tax_by_chk_itmzr_03 { get; set; }
        public decimal? incl_tax_by_chk_itmzr_04 { get; set; }
        public decimal? incl_tax_by_chk_itmzr_05 { get; set; }
        public decimal? incl_tax_by_chk_itmzr_06 { get; set; }
        public decimal? incl_tax_by_chk_itmzr_07 { get; set; }
        public decimal? incl_tax_by_chk_itmzr_08 { get; set; }
        public decimal? chk_begun_ttl { get; set; }
        public decimal? incl_svc_ttl { get; set; }
        public decimal? vat_by_ttl_itmzr_01 { get; set; }
        public decimal? vat_by_ttl_itmzr_02 { get; set; }
        public decimal? vat_by_ttl_itmzr_03 { get; set; }
        public decimal? vat_by_ttl_itmzr_04 { get; set; }
        public decimal? vat_by_ttl_itmzr_05 { get; set; }
        public decimal? vat_by_ttl_itmzr_06 { get; set; }
        public decimal? vat_by_ttl_itmzr_07 { get; set; }
        public decimal? vat_by_ttl_itmzr_08 { get; set; }
    }
}
