using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class ingrd_def
    {
        public int recipe_seq { get; set; }
        public int ingrd_seq { get; set; }
        public int obj_num { get; set; }
        public double qty { get; set; }
        public string ob_opn_qty { get; set; }
        public int unit_seq { get; set; }
        public string ingrd_type { get; set; }
        public int ingrd_type_seq { get; set; }
        public string ingrd_type_and_seq { get; set; }
        public string ob_scaleable { get; set; }
        public double? yield_ovrde { get; set; }
        public string ingrd_prep_cmnt { get; set; }
        public int? inven_cost_grp_seq { get; set; }
        public string ob_inven_deplete { get; set; }
        public string ob_incl_idl_cost { get; set; }
        public decimal? cnv_ovrde { get; set; }
        public int? maj_cnt_unit_seq { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public long? multi_user_access_seq { get; set; }
    }
}
