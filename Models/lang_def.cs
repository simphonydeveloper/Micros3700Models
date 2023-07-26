using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lang_def
    {
        public int lang_seq { get; set; }
        public string name { get; set; }
        public int obj_num { get; set; }
        public int primary_lang_seq { get; set; }
        public int sub_lang_seq { get; set; }
    }
}
