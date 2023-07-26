using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class export_section_def
    {
        public int export_seq { get; set; }
        public int export_section_seq { get; set; }
        public string export_section_type { get; set; }
        public string export_statement { get; set; }
        public string ob_rsvd01 { get; set; }
        public int? num_rsvd01 { get; set; }
        public string str_rsvd01 { get; set; }
    }
}
