using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class pm_bo_class_access_def
    {
        public int bo_class_access_seq { get; set; }
        public int func_access_id { get; set; }
        public int emp_bo_class_seq { get; set; }
        public int? ilcg_seq { get; set; }
        public string ob_access { get; set; }
    }
}
