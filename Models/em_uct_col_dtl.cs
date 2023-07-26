using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_uct_col_dtl
    {
        public int col_trans_seq { get; set; }
        public string host_name { get; set; }
        public string column_name { get; set; }
        public string literal_value { get; set; }
        public string ob_allow_edit { get; set; }
        public string ob_set_null { get; set; }
    }
}
