using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_screen_design_def
    {
        public int screen_design_seq { get; set; }
        public string dialog_id { get; set; }
        public int resource_id { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int w { get; set; }
        public int h { get; set; }
        public int flag { get; set; }
        public int font { get; set; }
        public int tab_order { get; set; }
        public string required { get; set; }
        public short? resolution { get; set; }
    }
}
