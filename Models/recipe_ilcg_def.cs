using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class recipe_ilcg_def
    {
        public int recipe_ilcg_seq { get; set; }
        public int recipe_seq { get; set; }
        public int ilcg_seq { get; set; }
        public int store_id { get; set; }
    }
}
