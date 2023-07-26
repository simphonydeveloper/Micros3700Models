using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cm_option_def
    {
        public int option_set_seq { get; set; }
        public string option_name { get; set; }
        public string option_value { get; set; }
        public string ob_system_option { get; set; }
    }
}
