using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_order_ref_dtl
    {
        public int order_ref_dtl_seq { get; set; }
        public int? order_mi_dtl_seq { get; set; }
        [Column("ref")]
        public string ref_2 { get; set; }
    }
}
