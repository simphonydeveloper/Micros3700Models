using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class emp_rot_def
    {
        public int emp_seq { get; set; }
        public int wk_num { get; set; }
        public int? min_hrs { get; set; }
        public int? max_hrs { get; set; }
    }
}
