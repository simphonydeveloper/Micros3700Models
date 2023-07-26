using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class om_topping_type_def
    {
        public int topping_type_seq { get; set; }
        public int? obj_num { get; set; }
        public string name { get; set; }
        public int? om_cfg_seq { get; set; }
    }
}
