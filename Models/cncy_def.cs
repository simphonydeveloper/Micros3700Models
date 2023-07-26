using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cncy_def
    {
        public int cncy_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public int? trans_name_seq { get; set; }
        public string cncy_iso_symbol { get; set; }
        public string cncy_symbol { get; set; }
        public short? cncy_digits_after_decimal { get; set; }
        public string ob_active { get; set; }
        public string cncy_id { get; set; }
        public long? multi_user_access_seq { get; set; }
    }
}
