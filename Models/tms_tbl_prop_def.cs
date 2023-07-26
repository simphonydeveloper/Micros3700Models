using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class tms_tbl_prop_def
    {
        public int tbl_prop_seq { get; set; }
        public int? obj_num { get; set; }
        public string prop_name { get; set; }
        public string ob_vital_prop { get; set; }
        public short? significance { get; set; }
        public string ob_required { get; set; }
    }
}
