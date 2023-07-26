using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class task_def
    {
        public int task_seq { get; set; }
        public int task_id { get; set; }
        public string name { get; set; }
        public int? ts_scrn_seq { get; set; }
    }
}
