using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class expo_tray_area_def
    {
        public int expo_tray_area_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public string prefix { get; set; }
        public short cnt { get; set; }
        public UInt16 max_usage_time { get; set; }
        public string ob_full_tray_rotation { get; set; }
    }
}
