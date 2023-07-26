using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class tms_employee_colors_def
    {
        public int color_seq { get; set; }
        public int? obj_num { get; set; }
        public int? employee_color { get; set; }
    }
}
