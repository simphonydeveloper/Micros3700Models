using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class otm_lvl_def
    {
        public int otm_lvl_seq { get; set; }
        public int? obj_num { get; set; }
        public string name { get; set; }
        public double? wg_multiplier { get; set; }
    }
}
