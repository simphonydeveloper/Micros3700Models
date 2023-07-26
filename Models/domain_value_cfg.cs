using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class domain_value_cfg
    {
        public int dmn_seq { get; set; }
        public int value_seq { get; set; }
        public int lang_seq { get; set; }
        public string valid_value_code { get; set; }
        public int? valid_value_num { get; set; }
        public string valid_value_def { get; set; }
        public string product_mask { get; set; }
    }
}
