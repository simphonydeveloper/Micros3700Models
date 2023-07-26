using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class om_size_def
    {
        public int size_seq { get; set; }
        public int? om_cfg_seq { get; set; }
        public int? obj_num { get; set; }
        public string name { get; set; }
        public string prefix { get; set; }
        public string ob_is_visible { get; set; }
    }
}
