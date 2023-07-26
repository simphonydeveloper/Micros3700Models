using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class ordr_itm_adjmt_dtl
    {
        public int ordr_itm_seq { get; set; }
        public int ordr_seq { get; set; }
        public int ordr_adjmt_seq { get; set; }
        public string ob_rcvd { get; set; }
    }
}
