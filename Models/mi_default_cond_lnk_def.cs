using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class mi_default_cond_lnk_def
    {
        public int mi_seq { get; set; }
        public int cond_default_set_seq { get; set; }
        public short order_num { get; set; }
        public short? override_level { get; set; }
    }
}
