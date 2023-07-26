using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_srg_shift_def
    {
        public int skill_lvl_reqmnt_seq { get; set; }
        public int skill_lvl_seq { get; set; }
        public int srg_shift_seq { get; set; }
        public int? section_seq { get; set; }
        public short? in_time { get; set; }
        public short? out_time { get; set; }
    }
}
