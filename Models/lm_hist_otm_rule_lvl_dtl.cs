using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_hist_otm_rule_lvl_dtl
    {
        public int otm_rule_lvl_hist_seq { get; set; }
        public int? log_seq { get; set; }
        public int? otm_rule_seq { get; set; }
        public int? otm_lvl_seq { get; set; }
        public short? hrs_before_sun_otm { get; set; }
        public short? hrs_before_mon_otm { get; set; }
        public short? hrs_before_tue_otm { get; set; }
        public short? hrs_before_wed_otm { get; set; }
        public short? hrs_before_thu_otm { get; set; }
        public short? hrs_before_fri_otm { get; set; }
        public short? hrs_before_sat_otm { get; set; }
        public short? hrs_before_prd_otm { get; set; }
        public short? consec_days_before_otm { get; set; }
        public short? hrs_in_prd_bf_consec_otm { get; set; }
        public short? hrs_in_day_bf_consec_otm { get; set; }
        public int? num_days_before_otm { get; set; }
    }
}
