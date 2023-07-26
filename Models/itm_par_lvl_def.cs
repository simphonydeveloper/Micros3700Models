using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class itm_par_lvl_def
    {
        public int inven_itm_ilcg_seq { get; set; }
        public int par_lvl_seq { get; set; }
        public double? par_lvl_amt { get; set; }
        public double? safety_stk_ovrde { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
