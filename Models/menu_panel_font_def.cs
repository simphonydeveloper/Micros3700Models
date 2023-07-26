using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class menu_panel_font_def
    {
        public int menu_panel_font_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public string face_name { get; set; }
        public short font_size { get; set; }
        public string ob_bold { get; set; }
        public string ob_underlined { get; set; }
        public string ob_italic { get; set; }
        public int font_color { get; set; }
        public int? bkgrd_color { get; set; }
    }
}
