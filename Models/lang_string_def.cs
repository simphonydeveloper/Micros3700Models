using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lang_string_def
    {
        public int string_seq { get; set; }
        public int lang_seq { get; set; }
        public string lang_text { get; set; }
        public int app_code { get; set; }
        public short modify_state { get; set; }
    }
}
