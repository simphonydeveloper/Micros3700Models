using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class menu_panel_def
    {
        public int menu_panel_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public int? bkgrd_color { get; set; }
        public byte? border_size { get; set; }
        public string header { get; set; }
        public int? header_font_seq { get; set; }
        public short? header_indent { get; set; }
        public short? header_height { get; set; }
        public string header_alignment { get; set; }
        public byte? item_width { get; set; }
        public string ob_suppress_header { get; set; }
        public string ob_is_picture { get; set; }
        public string image_name { get; set; }
    }
}
