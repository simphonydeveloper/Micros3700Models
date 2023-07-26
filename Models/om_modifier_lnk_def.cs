using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class om_modifier_lnk_def
    {
        public int modifier_lnk_seq { get; set; }
        public int modifier_seq { get; set; }
        public int top_mi_seq { get; set; }
        public int top_mi_obj_num { get; set; }
        public int link_mi_seq { get; set; }
        public decimal count_modifier { get; set; }
    }
}
