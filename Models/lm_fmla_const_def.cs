using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_fmla_const_def
    {
        public int fmla_const_seq { get; set; }
        public int? obj_num { get; set; }
        public string name { get; set; }
        public string data_type { get; set; }
        public double? val { get; set; }
        public int? mtx_seq { get; set; }
    }
}
