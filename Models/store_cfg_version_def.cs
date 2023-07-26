using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class store_cfg_version_def
    {
        public int store_id { get; set; }
        public string scrn_type { get; set; }
        public int scrn_seq { get; set; }
        public int? current_version_seq { get; set; }
    }
}
