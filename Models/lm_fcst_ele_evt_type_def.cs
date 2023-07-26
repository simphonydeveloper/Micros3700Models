using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_fcst_ele_evt_type_def
    {
        public int fcst_ele_seq { get; set; }
        public int evt_type_seq { get; set; }
        public short optr { get; set; }
        public string ob_same_day_adj { get; set; }
    }
}
