using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class menu_panel_price_lvl_def
    {
        public int menu_panel_price_lvl_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public int menu_panel_seq { get; set; }
        public short price_lvl { get; set; }
        public int? font_seq { get; set; }
        public string alignment { get; set; }
        public string ob_use_name { get; set; }
    }
}
