using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_price_dependency_term
    {
        public int mi_seq { get; set; }
        public int dep_item_seq { get; set; }
        public decimal? percent_multiplier { get; set; }
    }
}
