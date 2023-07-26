using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class tip_declared_dtl
    {
        public int trans_seq { get; set; }
        public decimal decl_amt { get; set; }
        public string ob_indirect_tip { get; set; }
    }
}
