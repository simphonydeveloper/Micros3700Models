using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class om_specialty_topping_lnk_def
    {
        public int specialty_lnk_seq { get; set; }
        public int? specialty_seq { get; set; }
        public int? topping_type_seq { get; set; }
        public int? modifier_seq { get; set; }
    }
}
