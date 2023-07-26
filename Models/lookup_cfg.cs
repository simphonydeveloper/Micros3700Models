using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lookup_cfg
    {
        public int lookup_cfg_seq { get; set; }
        public string tbl_name { get; set; }
        public string col_name { get; set; }
        public string data_type { get; set; }
        public string deflt_value_def { get; set; }
        public int? dmn_seq { get; set; }
    }
}
