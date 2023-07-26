using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cancel_dtl
    {
        public int trans_seq { get; set; }
        public decimal cancel_ttl { get; set; }
    }
}
