using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class om_modifier_def
    {
        public int modifier_seq { get; set; }
        public int? obj_num { get; set; }
        public string name { get; set; }
        public string ob_is_no { get; set; }
        public string ob_is_add { get; set; }
        public string caption { get; set; }
        public int? color { get; set; }
        public int? selected_color { get; set; }
        public decimal count_modifier { get; set; }
        public string ob_skip_on_specialty { get; set; }
        public string ob_skip_on_topping { get; set; }
    }
}
