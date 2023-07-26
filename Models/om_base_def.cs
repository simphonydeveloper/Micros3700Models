using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class om_base_def
    {
        public int base_seq { get; set; }
        public int? om_cfg_seq { get; set; }
        public int? mi_seq { get; set; }
        public int? obj_num { get; set; }
        public string name { get; set; }
        public short? default_size_seq { get; set; }
        public int? container_mi_seq { get; set; }
    }
}
