using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cm_safe_template_def
    {
        public int safe_template_seq { get; set; }
        public string safe_name { get; set; }
        public int? parlevel_seq { get; set; }
        public string ob_create_store_safe { get; set; }
        public int? countsheet_seq { get; set; }
    }
}
