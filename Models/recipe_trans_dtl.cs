using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class recipe_trans_dtl
    {
        public int inven_trans_seq { get; set; }
        public int recipe_seq { get; set; }
        public int? unit_seq { get; set; }
        public double qty { get; set; }
        public double? val { get; set; }
        public int? closed_prd_trans_seq { get; set; }
    }
}
