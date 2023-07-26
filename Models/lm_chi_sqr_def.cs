using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_chi_sqr_def
    {
        public int dof { get; set; }
        public int conf_lvl { get; set; }
        public double? chi_sqr_val { get; set; }
    }
}
