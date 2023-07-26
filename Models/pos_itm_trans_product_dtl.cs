using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class pos_itm_trans_product_dtl
    {
        public int pos_trans_seq { get; set; }
        public int srv_seq { get; set; }
        public int dtl_seq { get; set; }
        public DateTime bus_date { get; set; }
        public int rvc_seq { get; set; }
        public short pos_trans_type { get; set; }
        public short cnt { get; set; }
        public decimal? wght { get; set; }
        public int product_seq { get; set; }
        public DateTime trans_date { get; set; }
    }
}
