using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class user_domain_value_cfg
    {
        public int user_dmn_seq { get; set; }
        public int user_dmn_value_seq { get; set; }
        public int? valid_value_num { get; set; }
        public string valid_valid_code { get; set; }
        public string description { get; set; }
    }
}
