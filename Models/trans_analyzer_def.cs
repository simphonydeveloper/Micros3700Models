using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class trans_analyzer_def
    {
        public int ta_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public string ob_read_only { get; set; }
        public string version_type { get; set; }
        public decimal? version { get; set; }
    }
}
