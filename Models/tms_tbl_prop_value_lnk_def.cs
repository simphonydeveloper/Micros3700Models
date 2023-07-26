using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class tms_tbl_prop_value_lnk_def
    {
        public int tbl_prop_value_lnk_seq { get; set; }
        public int tbl_seq { get; set; }
        public int tbl_prop_value_seq { get; set; }
    }
}
