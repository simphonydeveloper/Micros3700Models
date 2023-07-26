using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class ilcg_par_lvl_def
    {
        public int ilcg_par_lvl_seq { get; set; }
        public string ob_default { get; set; }
        public int ilcg_seq { get; set; }
        public int par_lvl_seq { get; set; }
    }
}
