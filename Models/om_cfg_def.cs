using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class om_cfg_def
    {
        public int om_cfg_seq { get; set; }
        public int? obj_num { get; set; }
        public string name { get; set; }
        public int? default_section_seq { get; set; }
        public string no_label { get; set; }
        public int? default_base_seq { get; set; }
        public int? default_specialty_seq { get; set; }
        public string price_method { get; set; }
        public int? base_color { get; set; }
        public int? base_selected_color { get; set; }
        public int? size_color { get; set; }
        public int? size_selected_color { get; set; }
        public int? specialty_color { get; set; }
        public int? specialty_selected_color { get; set; }
        public int? modifier_color { get; set; }
        public int? section_color { get; set; }
        public int? section_selected_color { get; set; }
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
        public string sizes_label { get; set; }
        public string specialties_label { get; set; }
        public string bases_label { get; set; }
        public string toppings_label { get; set; }
        public string ob_include_condiment_prices_with_base_item { get; set; }
    }
}
