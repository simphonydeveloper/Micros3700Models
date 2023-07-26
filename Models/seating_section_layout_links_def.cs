using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class seating_section_layout_links_def
    {
        public int? source_layout_seq { get; set; }
        public int? linked_layout_seq { get; set; }
    }
}
