using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class stored_proc_parm_def
    {
        public int stored_proc_seq { get; set; }
        public int stored_proc_parm_seq { get; set; }
        public string name { get; set; }
        public string parm_id { get; set; }
        public string parm_data_type { get; set; }
        public decimal? default_numeric_value { get; set; }
        public string default_string_value { get; set; }
        public short? max_string_len { get; set; }
        public short? user_data_type { get; set; }
        public int? last_updated_by { get; set; }
    }
}
