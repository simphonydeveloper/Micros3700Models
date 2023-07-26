using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class kds_element_cfg
    {
        public int kds_element_seq { get; set; }
        public string name { get; set; }
        public string element_id { get; set; }
        public string ob_use_on_chit { get; set; }
        public string ob_use_on_list { get; set; }
    }
}
