using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_product_def
    {
        public int product_seq { get; set; }
        public string name { get; set; }
        public string version { get; set; }
    }
}
