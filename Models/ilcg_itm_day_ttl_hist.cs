using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class ilcg_itm_day_ttl_hist
    {
        public DateTime begin_bus_date { get; set; }
        public DateTime end_bus_date { get; set; }
        public short date_range_type { get; set; }
        public int inven_itm_seq { get; set; }
        public int ilcg_seq { get; set; }
        public string dirty { get; set; }
        public double? on_hand_qty { get; set; }
        public double on_hand_val { get; set; }
        public double fifo_val { get; set; }
        public double wac_val { get; set; }
        public double lc_val { get; set; }
        public DateTime? lc_date { get; set; }
        public double ttl_theo_usage_qty { get; set; }
        public double ttl_theo_usage_val { get; set; }
        public double ttl_wste_qty { get; set; }
        public double ttl_wste_val { get; set; }
        public double ttl_xfer_in_qty { get; set; }
        public double ttl_xfer_in_val { get; set; }
        public double ttl_xfer_out_qty { get; set; }
        public double ttl_xfer_out_val { get; set; }
        public double ttl_rcpt_qty { get; set; }
        public double ttl_rcpt_val { get; set; }
        public double ttl_var_adjmt_qty { get; set; }
        public double ttl_var_adjmt_val { get; set; }
        public double ttl_prev_prd_cor_qty { get; set; }
        public double ttl_prev_prd_cor_val { get; set; }
        public double ttl_prod_qty { get; set; }
        public double ttl_prod_val { get; set; }
        public int em_ttl_repl_seq { get; set; }
        public int store_id { get; set; }
        public int? cncy_seq { get; set; }
    }
}
