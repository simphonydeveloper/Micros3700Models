using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class period_def
    {
        public int prd_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public short? start_time { get; set; }
        public short? end_time { get; set; }
        public int? start_fixed_period_seq { get; set; }
        public int? end_fixed_period_seq { get; set; }
        public string ob_b01_active_sun { get; set; }
        public string ob_b02_active_mon { get; set; }
        public string ob_b03_active_tue { get; set; }
        public string ob_b04_active_wed { get; set; }
        public string ob_b05_active_thu { get; set; }
        public string ob_b06_active_fri { get; set; }
        public string ob_b07_active_sat { get; set; }
        public string ob_rsvd01 { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
