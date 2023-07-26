using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class tmp_inven_itm_trans_dtl
    {
        public int inven_trans_seq { get; set; }
        public int inven_itm_seq { get; set; }
        public int? unit_seq { get; set; }
        public double qty { get; set; }
        public double? val { get; set; }
        public string ob_incl_idl_cost { get; set; }
    }
}
