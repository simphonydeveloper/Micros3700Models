using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class allowance_trans_dtl
    {
        public int allowance_trans_seq { get; set; }
        public int? inven_trans_seq { get; set; }
        public int? itm_seq { get; set; }
        public string itm_type { get; set; }
        public int allowance_seq { get; set; }
        public double? qty { get; set; }
        public int? unit_seq { get; set; }
        public int? ilcg_seq { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public DateTime? decl_date { get; set; }
        public string ob_dirty { get; set; }
        public string reason_desc { get; set; }
        public long? multi_user_access_seq { get; set; }
        public string ob_usage { get; set; }
        public double? item_weight { get; set; }
        public int? closed_prd_trans_seq { get; set; }
    }
}
