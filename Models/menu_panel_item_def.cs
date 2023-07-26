using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class menu_panel_item_def
    {
        public int menu_panel_item_seq { get; set; }
        public int obj_num { get; set; }
        public string custom_name { get; set; }
        public string description { get; set; }
        public int menu_panel_seq { get; set; }
        public int? mi_seq { get; set; }
        public int? font_seq { get; set; }
        public string alignment { get; set; }
        public short? height { get; set; }
        public short? indent { get; set; }
        public byte? name_source { get; set; }
    }
}
