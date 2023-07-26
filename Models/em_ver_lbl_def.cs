using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_ver_lbl_def
    {
        public int version_seq { get; set; }
        public int? store_seq { get; set; }
        public int? store_grp_seq { get; set; }
        public string name { get; set; }
        public string ob_default { get; set; }
        public string ob_system { get; set; }
        public string ob_touchscreen { get; set; }
    }
}
