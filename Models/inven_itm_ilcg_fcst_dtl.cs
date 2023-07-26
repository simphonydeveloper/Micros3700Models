using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class inven_itm_ilcg_fcst_dtl
    {
        public int inven_itm_seq { get; set; }
        public int ilcg_seq { get; set; }
        public DateTime bus_date { get; set; }
        public double? fcst_qty { get; set; }
    }
}
