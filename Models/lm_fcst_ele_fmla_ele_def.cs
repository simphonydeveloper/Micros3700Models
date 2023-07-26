using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_fcst_ele_fmla_ele_def
    {
        public int fmla_seq { get; set; }
        public int fmla_ele_seq { get; set; }
        public int? fcst_ele_seq { get; set; }
    }
}
