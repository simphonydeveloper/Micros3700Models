using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cond_default_set_def
    {
        public int cond_default_set_seq { get; set; }
        public int? obj_num { get; set; }
        public string name { get; set; }
    }
}
