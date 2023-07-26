using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_time_series_bus_pattern_dtl
    {
        public int time_series_seq { get; set; }
        public int time_series_bus_pattern_seq { get; set; }
        public string name { get; set; }
        public int? mtx_seq { get; set; }
        public double? col_dist_day_1 { get; set; }
        public double? col_dist_day_2 { get; set; }
        public double? col_dist_day_3 { get; set; }
        public double? col_dist_day_4 { get; set; }
        public double? col_dist_day_5 { get; set; }
        public double? col_dist_day_6 { get; set; }
        public double? col_dist_day_7 { get; set; }
    }
}
