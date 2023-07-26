using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_fcst_grp_def
    {
        public int fcst_grp_seq { get; set; }
        public int? obj_num { get; set; }
        public string name { get; set; }
        public int? primary_fcst_ele_seq { get; set; }
        public string ob_scheduling { get; set; }
        public string ob_associated_fcst { get; set; }
        public string ob_rsvd02 { get; set; }
        public string ob_rsvd03 { get; set; }
        public string ob_rsvd04 { get; set; }
    }
}
