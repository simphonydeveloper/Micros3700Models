using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_key_pool_def
    {
        public string name { get; set; }
        public int replenish_threshold { get; set; }
        public int replenish_level { get; set; }
    }
}
