using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class component_set_mem_def
    {
        public int component_set_seq { get; set; }
        public int mi_seq { get; set; }
        public short order_num { get; set; }
    }
}
