using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class inven_itm_class_adjmt_dtl
    {
        public int inven_itm_class_adjmt_dtl_seq { get; set; }
        public int inven_itm_class_seq { get; set; }
        public int adjmt_seq { get; set; }
    }
}
