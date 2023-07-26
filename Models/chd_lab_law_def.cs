using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class chd_lab_law_def
    {
        public int fed_state_law_seq { get; set; }
        public int chd_lab_law_seq { get; set; }
        public int? otm_rule_seq { get; set; }
        public short? max_hrs_schl_day { get; set; }
        public short? max_hrs_non_schl_day { get; set; }
        public short? max_hrs_schl_wk { get; set; }
        public short? max_hrs_non_schl_wk { get; set; }
        public short? max_day_schl_wk { get; set; }
        public short? max_day_non_schl_wk { get; set; }
        public short? max_consec_day { get; set; }
        public string ob_age_cert { get; set; }
        public string ob_empmt_cert { get; set; }
        public string ob_sun_excl { get; set; }
        public double? job_rstrc { get; set; }
        public string ob_wrk_permit { get; set; }
        public short? earliest_tm_schl_day { get; set; }
        public short? earliest_tm_non_schl_day { get; set; }
        public short? latest_wrk_schl_day { get; set; }
        public short? latest_wrk_non_schl_day { get; set; }
        public short? min_age { get; set; }
        public short? max_age { get; set; }
        public int? max_min_before_brk_schl_day { get; set; }
        public int? max_min_before_brk_non_schl_day { get; set; }
    }
}
