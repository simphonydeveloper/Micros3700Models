using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_deduction_def
    {
        public int deduction_seq { get; set; }
        public int? obj_num { get; set; }
        public string name { get; set; }
        public decimal? deflt_amt { get; set; }
        public decimal? deflt_pctge { get; set; }
        public int? deflt_type { get; set; }
        public string EM_GUID { get; set; }
    }
}
