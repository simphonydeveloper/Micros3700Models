using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class xfer_itm_dtl
    {
        public int store_id { get; set; }
        public int xfer_seq { get; set; }
        public int xfer_itm_seq { get; set; }
        public int? inven_trans_seq { get; set; }
        public int? inven_itm_seq { get; set; }
        public int? acct_seq { get; set; }
        public double? qty { get; set; }
        public int unit_seq { get; set; }
        public double? itm_price { get; set; }
        public string ob_price_change { get; set; }
        public int? closed_prd_trans_seq { get; set; }
    }
}
