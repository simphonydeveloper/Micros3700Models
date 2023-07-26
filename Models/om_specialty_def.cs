using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class om_specialty_def
    {
        public int specialty_seq { get; set; }
        public int? obj_num { get; set; }
        public string name { get; set; }
        public short? any_topping_count { get; set; }
        public int? om_cfg_seq { get; set; }
        public short? max_topping_count { get; set; }
    }
}
