using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class rpt_viewer_access_def
    {
        public int rpt_template_seq { get; set; }
        public int emp_class_seq { get; set; }
        public string ob_view { get; set; }
        public string ob_modify { get; set; }
        public string ob_print { get; set; }
        public int? default_range_seq { get; set; }
    }
}
