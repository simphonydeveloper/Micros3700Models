using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_fcst_ele_aggregate_def
    {
        public int fcst_ele_seq { get; set; }
        public int aggregate_fcst_ele_seq { get; set; }
    }
}
