using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_text_wizard_step_def
    {
        public int text_wizard_step_seq { get; set; }
        public string user_defined_field { get; set; }
        public int? step { get; set; }
        public string text_prefix { get; set; }
        public int text_wizard_seq { get; set; }
    }
}
