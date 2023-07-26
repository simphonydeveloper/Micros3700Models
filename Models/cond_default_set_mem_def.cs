using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cond_default_set_mem_def
    {
        public int cond_default_set_mem_seq { get; set; }
        public int cond_default_set_seq { get; set; }
        public int mi_seq { get; set; }
        public short order_num { get; set; }
        public string no { get; set; }
        public string stay_on_plain { get; set; }
        public string not_modified_by_all { get; set; }
    }
}
