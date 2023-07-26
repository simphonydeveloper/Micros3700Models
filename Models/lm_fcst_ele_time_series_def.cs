using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_fcst_ele_time_series_def
    {
        public int fcst_ele_seq { get; set; }
        public int time_series_seq { get; set; }
    }
}
