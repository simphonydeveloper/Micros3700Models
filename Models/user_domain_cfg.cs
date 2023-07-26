using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class user_domain_cfg
    {
        public int user_dmn_seq { get; set; }
        public int? obj_num { get; set; }
        public string name { get; set; }
        public string user_dmn_name { get; set; }
        public string ob_numeric { get; set; }
    }
}
