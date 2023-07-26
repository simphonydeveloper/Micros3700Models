using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class mi_set_detail_def
    {
        public int seq { get; set; }
        public int? mi_set_seq { get; set; }
        public int? type { get; set; }
        public int? start_obj_num { get; set; }
        public int? end_obj_num { get; set; }
        public string ob_exclude { get; set; }
        public string ob_price_1_active { get; set; }
        public string ob_price_2_active { get; set; }
        public string ob_price_3_active { get; set; }
        public string ob_price_4_active { get; set; }
        public string ob_price_5_active { get; set; }
        public string ob_price_6_active { get; set; }
        public string ob_price_7_active { get; set; }
        public string ob_price_8_active { get; set; }
        public string ob_price_9_active { get; set; }
        public string ob_price_10_active { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
    }
}
