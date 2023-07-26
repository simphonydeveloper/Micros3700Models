using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class seating_section_layout_tbl_def
    {
        public int seq { get; set; }
        public int layout_seq { get; set; }
        public int tbl_seq { get; set; }
        public int section_seq { get; set; }
        public int? emp_seq { get; set; }
    }
}
