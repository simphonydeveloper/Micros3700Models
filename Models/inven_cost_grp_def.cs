using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class inven_cost_grp_def
    {
        public int inven_cost_grp_seq { get; set; }
        public int? maj_grp_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public string ob_ovrde_inven_valuation_mthd { get; set; }
        public short? ovrde_inven_valuation_mthd { get; set; }
        public int acct_seq { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public long? multi_user_access_seq { get; set; }
    }
}
