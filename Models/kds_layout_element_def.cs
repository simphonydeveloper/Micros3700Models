using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class kds_layout_element_def
    {
        public int kds_layout_seq { get; set; }
        public int kds_layout_element_seq { get; set; }
        public int? kds_element_seq { get; set; }
        public int? alt_kds_element_seq { get; set; }
        public string justification { get; set; }
        public int? row { get; set; }
        public int? column { get; set; }
        public string col_title { get; set; }
        public int? col_width { get; set; }
        public int? font_seq { get; set; }
        public int? font_size { get; set; }
        public string ob_font_bold { get; set; }
        public int foreground_color { get; set; }
        public int? last_updated_by { get; set; }
    }
}
