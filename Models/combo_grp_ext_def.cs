using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class combo_grp_ext_def
    {
        public int combo_grp_ext_seq { get; set; }
        public int obj_num { get; set; }
        public string extension_name { get; set; }
    }
}
