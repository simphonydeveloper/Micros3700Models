using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class om_meal_link_def
    {
        public int meal_link_seq { get; set; }
        public int? meal_seq { get; set; }
        public int? specialty_seq { get; set; }
        public short? meal_link_num { get; set; }
    }
}
