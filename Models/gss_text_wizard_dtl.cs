using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_text_wizard_dtl
    {
        public int text_wizard_dtl_seq { get; set; }
        public int text_wizard_seq { get; set; }
        public string wizard_text { get; set; }
    }
}
