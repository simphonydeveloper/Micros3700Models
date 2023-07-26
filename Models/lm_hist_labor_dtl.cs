using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_hist_labor_dtl
    {
        public int labor_hist_seq { get; set; }
        public int? log_seq { get; set; }
        public int? store_id { get; set; }
        public int? fed_state_law_seq { get; set; }
        public short? bus_day_start_tm { get; set; }
        public short? lab_wk_start_day { get; set; }
        public string ob_no_dly_otm_in_weekly { get; set; }
        public string ob_weighted_average_ot { get; set; }
    }
}
