using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class mi_product_def
    {
        public int mi_seq { get; set; }
        public int menu_lvl { get; set; }
        public int? product_seq { get; set; }
        public double? ratio { get; set; }
        public string ob_visible { get; set; }
    }
}
