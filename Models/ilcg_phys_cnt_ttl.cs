using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class ilcg_phys_cnt_ttl
    {
        public int inven_itm_seq { get; set; }
        public int ilcg_seq { get; set; }
        public int phys_cnt_seq { get; set; }
        public double ttl_cnt { get; set; }
        public double on_hand_qty { get; set; }
        public short loc_to_cnt { get; set; }
        public short cnt_cnt { get; set; }
        public double? on_hand_val { get; set; }
        public double? fifo_val { get; set; }
        public double? wac_val { get; set; }
        public double? lc_val { get; set; }
        public DateTime? lc_date { get; set; }
        public double? ttl_theo_usage_qty { get; set; }
        public double? ttl_theo_usage_val { get; set; }
        public double? ttl_wste_qty { get; set; }
        public double? ttl_wste_val { get; set; }
        public double? ttl_xfer_in_qty { get; set; }
        public double? ttl_xfer_in_val { get; set; }
        public double? ttl_xfer_out_qty { get; set; }
        public double? ttl_xfer_out_val { get; set; }
        public double? ttl_rcpt_qty { get; set; }
        public double? ttl_rcpt_val { get; set; }
        public double? ttl_var_adjmt_qty { get; set; }
        public double? ttl_var_adjmt_val { get; set; }
        public double? ttl_prev_prd_cor_qty { get; set; }
        public double? ttl_prev_prd_cor_val { get; set; }
        public double? ttl_prod_qty { get; set; }
        public double? ttl_prod_val { get; set; }
    }
}
