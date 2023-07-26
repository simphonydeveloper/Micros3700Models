using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class time_period_def
    {
        public int time_period_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public int? prd_seq { get; set; }
        public int? su_trk_grp_seq { get; set; }
        public string ob_tprd_dont_prn_ohd { get; set; }
        public DateTime? last_updated_date { get; set; }
        public int? last_updated_by { get; set; }
        public string ob_kpi { get; set; }
    }
}
