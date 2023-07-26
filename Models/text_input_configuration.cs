using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class text_input_configuration
    {
        public int text_input_configuration_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public string file_name { get; set; }
        public string wizard_name { get; set; }
    }
}
