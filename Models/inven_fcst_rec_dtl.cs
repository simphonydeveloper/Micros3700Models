using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class inven_fcst_rec_dtl
    {
        public int ilcg_seq { get; set; }
        public int inven_itm_seq { get; set; }
        public int period_num { get; set; }
        public double? qty { get; set; }
    }
}
