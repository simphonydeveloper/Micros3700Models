using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class eff_prd_def
    {
        public int eff_prd_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public string ob_active { get; set; }
        public string ob_readonly { get; set; }
        public string ob_recurring { get; set; }
        public DateTime? sched_year { get; set; }
        public string ob_use_date { get; set; }
        public string ob_use_dow { get; set; }
        public string ob_use_time { get; set; }
        public string ob_dly_mon { get; set; }
        public string ob_dly_tue { get; set; }
        public string ob_dly_wed { get; set; }
        public string ob_dly_thu { get; set; }
        public string ob_dly_fri { get; set; }
        public string ob_dly_sat { get; set; }
        public string ob_dly_sun { get; set; }
        public DateTime? season_start { get; set; }
        public DateTime? season_end { get; set; }
        public int? hour_00_07 { get; set; }
        public int? hour_08_15 { get; set; }
        public int? hour_16_23 { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public long? multi_user_access_seq { get; set; }
    }
}
