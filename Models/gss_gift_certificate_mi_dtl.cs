using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_gift_certificate_mi_dtl
    {
        public int gift_certificate_mi_dtl_seq { get; set; }
        public int gift_certificate_seq { get; set; }
        public int? mi_seq { get; set; }
        public string is_value_add { get; set; }
    }
}
