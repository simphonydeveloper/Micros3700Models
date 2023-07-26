using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class encrypt_key_def
    {
        public int key_seq { get; set; }
        public string pass_phrase { get; set; }
        public string key_type { get; set; }
    }
}
