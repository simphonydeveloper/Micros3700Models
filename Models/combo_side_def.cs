using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class combo_side_def
    {
        public int combo_side_seq { get; set; }
        public int combo_grp_seq { get; set; }
        public int? combo_seq { get; set; }
        public int? side_num { get; set; }
        public short? override_level { get; set; }
        public int? mlvl_mask { get; set; }
    }
}
