using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class kds_button_cfg
    {
        public int kds_button_seq { get; set; }
        public string name { get; set; }
        public int? kds_function { get; set; }
        public string ob_use_on_bumpbar { get; set; }
        public string ob_use_on_toolbar { get; set; }
        public string ob_expect_dialog { get; set; }
        public string ob_rsvd { get; set; }
        public string str_rsvd { get; set; }
        public int? num_rsvd { get; set; }
    }
}
