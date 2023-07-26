using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class mi_substitute_def
    {
        public int mi_seq { get; set; }
        public int cond_default_set_seq { get; set; }
        public int mi_swap_seq { get; set; }
        public int? combo_swap_seq { get; set; }
    }
}
