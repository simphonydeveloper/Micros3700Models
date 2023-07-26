using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class generic_pos_product_map_def
    {
        public int mi_seq { get; set; }
        public int? product_seq { get; set; }
        public int? mi_level { get; set; }
        public string ob_enabled { get; set; }
        public decimal ratio { get; set; }
    }
}
