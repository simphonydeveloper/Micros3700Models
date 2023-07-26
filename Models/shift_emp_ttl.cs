using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class shift_emp_ttl
    {
        public int store_id { get; set; }
        public int emp_seq { get; set; }
        public int shift_seq { get; set; }
        public decimal net_sls_ttl { get; set; }
        public decimal item_dsc_ttl { get; set; }
        public decimal sttl_dsc_ttl { get; set; }
        public decimal svc_ttl { get; set; }
        public int rtn_cnt { get; set; }
        public decimal rtn_ttl { get; set; }
        public int void_cnt { get; set; }
        public decimal void_ttl { get; set; }
        public decimal tax_coll_ttl { get; set; }
        public decimal credit_ttl { get; set; }
        public decimal rounding_ttl { get; set; }
        public decimal change_grand_ttl { get; set; }
        public decimal training_ttl { get; set; }
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
        public int chk_xfer_in_cnt { get; set; }
        public decimal chk_xfer_in_ttl { get; set; }
        public int chk_xfer_out_cnt { get; set; }
        public decimal chk_xfer_out_ttl { get; set; }
        public int cov_cnt { get; set; }
        public int chk_cnt { get; set; }
        public int tbl_turn_cnt { get; set; }
        public int tbl_dine_time { get; set; }
        public int no_sale_cnt { get; set; }
        public decimal gross_rcpts_ttl { get; set; }
        public decimal charged_rcpts_ttl { get; set; }
        public decimal charged_tips_ttl { get; set; }
        public decimal tip_svc_ttl { get; set; }
        public decimal tips_paid_ttl { get; set; }
        public decimal tips_decl_ttl { get; set; }
        public decimal? ind_tips_paid_ttl { get; set; }
        public DateTime shift_start_time { get; set; }
        public DateTime? shift_end_time { get; set; }
        public int em_ttl_repl_seq { get; set; }
        public string ob_posted_time_card_dtl { get; set; }
        public decimal? comm_ttl { get; set; }
        public decimal? emp_svc_tip_ttl { get; set; }
        public decimal? tip_share_amt { get; set; }
    }
}
