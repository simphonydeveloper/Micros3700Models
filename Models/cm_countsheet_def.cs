using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cm_countsheet_def
    {
        public int countsheet_seq { get; set; }
        public string countsheet_name { get; set; }
        public string countsheet_layout { get; set; }
        public int countsheet_layout_version { get; set; }
    }
}
