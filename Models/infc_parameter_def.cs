using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class infc_parameter_def
    {
        public int store_id { get; set; }
        public string null_character { get; set; }
        public string default_path { get; set; }
        public string dups_option { get; set; }
    }
}
