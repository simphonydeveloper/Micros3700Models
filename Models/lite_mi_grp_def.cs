using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lite_mi_grp_def
    {
        public int lite_mi_grp_seq { get; set; }
        public int? maj_grp_seq { get; set; }
        public int? fam_grp_seq { get; set; }
        public int? mi_type_class_seq { get; set; }
        public int? tax_class_seq { get; set; }
    }
}
