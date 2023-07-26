using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class om_topping_type_lnk_def
    {
        public int topping_type_lnk_seq { get; set; }
        public int? topping_type_seq { get; set; }
        public int? section_seq { get; set; }
        public int? base_seq { get; set; }
        public int? mi_seq { get; set; }
        public string ob_size_01 { get; set; }
        public string ob_size_02 { get; set; }
        public string ob_size_03 { get; set; }
        public string ob_size_04 { get; set; }
        public string ob_size_05 { get; set; }
        public string ob_size_06 { get; set; }
        public string ob_size_07 { get; set; }
        public string ob_size_08 { get; set; }
        public string ob_size_09 { get; set; }
        public string ob_size_10 { get; set; }
        public int? toppings_threshold_mi_seq { get; set; }
    }
}
