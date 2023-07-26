using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class sub_lang_def
    {
        public int sub_lang_seq { get; set; }
        public string sub_lang_name { get; set; }
        public int primary_lang_seq { get; set; }
    }
}
