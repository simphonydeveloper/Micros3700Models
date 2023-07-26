using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cm_environment_cfg
    {
        public string name { get; set; }
        public string value { get; set; }
        public string data_type { get; set; }
    }
}
