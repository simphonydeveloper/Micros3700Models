using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class inven_fcst_def
    {
        public int inven_fcst_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public string ob_inven_fcst { get; set; }
        public short inven_fcst_method { get; set; }
        public short inven_fcst_prds { get; set; }
        public short inven_fcst_prd_type { get; set; }
        public string ob_exclude_max { get; set; }
        public string ob_exclude_min { get; set; }
        public short inven_fcst_recent_wgt { get; set; }
        public string ob_inven_fcst_ilcg { get; set; }
        public int? inven_fcst_trans_types { get; set; }
        public short? inven_fcst_intvl { get; set; }
        public string ob_has_mem { get; set; }
        public DateTime? last_updated { get; set; }
    }
}
