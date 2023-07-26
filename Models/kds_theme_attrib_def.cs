using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class kds_theme_attrib_def
    {
        public int attrib_seq { get; set; }
        public string key_data { get; set; }
        public int kds_theme_seq { get; set; }
        public string data { get; set; }
    }
}
