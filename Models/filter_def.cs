using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class filter_def
    {
        public int filter_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public string ob_default { get; set; }
        public int? table_num { get; set; }
    }
}
