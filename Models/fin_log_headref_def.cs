using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class fin_log_headref_def
    {
        public int fin_log_headref_seq { get; set; }
        public string name { get; set; }
        public string obsolete { get; set; }
        public string ob_local { get; set; }
    }
}
