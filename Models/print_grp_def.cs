using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class print_grp_def
    {
        public int print_grp_seq { get; set; }
        public int? obj_num { get; set; }
        public string print_grp_name { get; set; }
        public string ob_show_print_grp_section { get; set; }
        public string ob_show_print_grp_sub_section { get; set; }
    }
}
