using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_fmla_def
    {
        public int fmla_seq { get; set; }
        public int? obj_num { get; set; }
        public string name { get; set; }
        public string ob_precompiled { get; set; }
        public string fmla_text { get; set; }
    }
}
