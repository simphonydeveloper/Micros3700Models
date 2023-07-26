using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class ilcg_itm_day_stk_dtl
    {
        public int store_id { get; set; }
        public DateTime bus_date { get; set; }
        public int inven_itm_seq { get; set; }
        public int ilcg_seq { get; set; }
        public DateTime stk_date { get; set; }
        public int in_trans_seq { get; set; }
        public double qty { get; set; }
        public double price { get; set; }
        public int? cncy_seq { get; set; }
    }
}
