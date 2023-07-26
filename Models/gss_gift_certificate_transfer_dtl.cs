using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_gift_certificate_transfer_dtl
    {
        public int transfer_from_seq { get; set; }
        public int transfer_to_seq { get; set; }
    }
}
