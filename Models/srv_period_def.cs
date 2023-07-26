using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class srv_period_def
    {
        public int srv_period_seq { get; set; }
        public int? rvc_seq { get; set; }
        public int? tax_class_seq { get; set; }
        public int? default_ts_scrn { get; set; }
        public int? prd_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public short? main_mlvl { get; set; }
        public short? sub_mlvl { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public int? hht_default_ts_scrn { get; set; }
    }
}
