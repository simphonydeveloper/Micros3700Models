using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cc_index_dtl
    {
        public int trans_seq { get; set; }
        public int dtl_seq { get; set; }
        public int chk_seq { get; set; }
    }
}
