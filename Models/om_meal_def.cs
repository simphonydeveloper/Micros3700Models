using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class om_meal_def
    {
        public int meal_seq { get; set; }
        public int? obj_num { get; set; }
        public int? combo_meal_grp_seq { get; set; }
        public int? specialty_seq { get; set; }
        public string name { get; set; }
        public string ob_toppings_priced { get; set; }
        public short? size_seq { get; set; }
    }
}
