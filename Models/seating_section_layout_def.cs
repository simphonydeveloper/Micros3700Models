using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class seating_section_layout_def
    {
        public int layout_seq { get; set; }
        public int? obj_num { get; set; }
        public string layout_name { get; set; }
        public int? rvc_seq { get; set; }
        public DateTime? last_accessed_date { get; set; }
    }
}
