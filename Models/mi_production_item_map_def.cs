using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class mi_production_item_map_def
    {
        public int mi_seq { get; set; }
        public int production_item_seq { get; set; }
        public decimal production_count { get; set; }
    }
}
