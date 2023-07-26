using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class desktop_access
    {
        public int emp_bo_class_seq { get; set; }
        public int menu_seq { get; set; }
        public int? access_lvl { get; set; }
    }
}
