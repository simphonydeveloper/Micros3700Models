using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cfg_version_def
    {
        public string scrn_type { get; set; }
        public int scrn_seq { get; set; }
        public int version_seq { get; set; }
        public string version_name { get; set; }
        public string ob_default { get; set; }
    }
}
