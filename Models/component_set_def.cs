using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class component_set_def
    {
        public int component_set_seq { get; set; }
        public int? obj_num { get; set; }
        public string name { get; set; }
        public int? prep_time { get; set; }
        public int? print_class_seq { get; set; }
        public string display_name { get; set; }
        public string ob_display_all_condiments { get; set; }
    }
}
