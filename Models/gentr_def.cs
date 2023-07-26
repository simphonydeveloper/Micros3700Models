using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gentr_def
    {
        public int gentr_seq { get; set; }
        public string name { get; set; }
        public int obj_num { get; set; }
        public short obj_type { get; set; }
        public string cmnt_ln { get; set; }
        public string sql_statement { get; set; }
    }
}
