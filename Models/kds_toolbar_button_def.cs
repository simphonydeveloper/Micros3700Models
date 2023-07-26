using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class kds_toolbar_button_def
    {
        public int kds_toolbar_seq { get; set; }
        public int button_position { get; set; }
        public int kds_button_seq { get; set; }
        public int foreground_color { get; set; }
        public int background_color { get; set; }
        public string legend { get; set; }
        public string icon_ref { get; set; }
        public string ob_anchored { get; set; }
        public int? last_updated_by { get; set; }
    }
}
