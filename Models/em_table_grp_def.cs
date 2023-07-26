using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_table_grp_def
    {
        public int em_table_grp_seq { get; set; }
        public int? obj_num { get; set; }
        public string name { get; set; }
        public string ob_enterprise_managed { get; set; }
    }
}
