using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class allowance_set_def
    {
        public int allowance_set_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public string ob_allowance_use { get; set; }
        public string ob_ilcg_use { get; set; }
        public long? multi_user_access_seq { get; set; }
    }
}
