using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_fcst_ele_def
    {
        public int fcst_ele_seq { get; set; }
        public int? obj_num { get; set; }
        public string name { get; set; }
        public int? time_series_seq { get; set; }
        public int? time_series_bus_pattern_seq { get; set; }
        public int? fmla_seq { get; set; }
        public int fcst_grp_seq { get; set; }
        public short? algo { get; set; }
        public short? fcst_prd { get; set; }
        public short? fcst_intv { get; set; }
        public string op_dstrb { get; set; }
        public decimal? alpha { get; set; }
        public decimal? beta { get; set; }
        public decimal? gamma { get; set; }
        public short? num_prd_avg { get; set; }
        public Single? slope { get; set; }
        public Single? intercept { get; set; }
        public short? fcst_ele_type { get; set; }
        public Single? scaling_fctr { get; set; }
        public decimal? wt_current { get; set; }
        public decimal? wt_history { get; set; }
        public string ob_replace_existing_forecast { get; set; }
        public string ob_auto_update_fcst { get; set; }
        public short? num_days_to_store { get; set; }
        public int? fcst_prd_grp_type { get; set; }
        public int? fcst_num_prd_grp { get; set; }
        public short? _precision_ { get; set; }
        public string ob_for_scheduling { get; set; }
        public string ob_rsvd01 { get; set; }
        public string ob_rsvd02 { get; set; }
        public string ob_rsvd03 { get; set; }
        public int? num_rsvd01 { get; set; }
        public int? num_rsvd02 { get; set; }
    }
}
