using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class tms_tbl_prop_value_def
    {
        public int tbl_prop_value_seq { get; set; }
        public int? obj_num { get; set; }
        public int tbl_prop_seq { get; set; }
        public string prop_name { get; set; }
        public short? icon_id { get; set; }
        public string short_name { get; set; }
    }
}
