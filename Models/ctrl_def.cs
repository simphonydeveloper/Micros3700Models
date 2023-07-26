using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class ctrl_def
    {
        public int form_seq { get; set; }
        public int tab_seq { get; set; }
        public string name { get; set; }
        public string cfg_info { get; set; }
    }
}
