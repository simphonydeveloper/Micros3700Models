using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class extensibility_dtl
    {
        public int extensibility_seq { get; set; }
        public int? extensibility_id { get; set; }
        public int chk_seq { get; set; }
        public short type { get; set; }
        public string string_data { get; set; }
        public int? application_id { get; set; }
        public string data_name { get; set; }
        public string display_name { get; set; }
    }
}
