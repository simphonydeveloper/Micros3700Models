using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lst_def
    {
        public int lst_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public short obj_type { get; set; }
        public string cmnt_ln { get; set; }
        public int? gentr_seq { get; set; }
        public string ob_dashboard { get; set; }
    }
}
