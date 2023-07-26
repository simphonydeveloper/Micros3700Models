using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class filter_steps_def
    {
        public int filter_seq { get; set; }
        public int filter_step_seq { get; set; }
        public string expression { get; set; }
        public string query_path { get; set; }
        public string type { get; set; }
    }
}
