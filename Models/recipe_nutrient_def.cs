using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class recipe_nutrient_def
    {
        public int recipe_seq { get; set; }
        public int nutrient_seq { get; set; }
        public double amt { get; set; }
        public int unit_seq { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
