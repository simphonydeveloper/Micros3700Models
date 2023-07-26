using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_key_pool_dtl
    {
        public string name { get; set; }
        public int value { get; set; }
        public int? site { get; set; }
        public string ob_used { get; set; }
    }
}
