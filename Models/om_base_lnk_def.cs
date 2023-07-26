using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class om_base_lnk_def
    {
        public int base_size_lnk_seq { get; set; }
        public int? base_seq { get; set; }
        public int? size_seq { get; set; }
        public short? topping_warning { get; set; }
        public string ob_section_01 { get; set; }
        public string ob_section_02 { get; set; }
        public string ob_section_03 { get; set; }
        public string ob_section_04 { get; set; }
        public string ob_section_05 { get; set; }
        public string ob_section_06 { get; set; }
        public string ob_section_07 { get; set; }
        public string ob_section_08 { get; set; }
        public string ob_section_09 { get; set; }
        public string ob_section_10 { get; set; }
        public short? recipe_change_threshold { get; set; }
    }
}
