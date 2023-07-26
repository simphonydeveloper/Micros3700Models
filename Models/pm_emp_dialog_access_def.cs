using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class pm_emp_dialog_access_def
    {
        public int emp_seq { get; set; }
        public short dialog_type { get; set; }
        public string ob_show { get; set; }
    }
}
