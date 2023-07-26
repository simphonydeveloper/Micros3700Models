using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class rcv_itm_net_chng_dtl
    {
        public int net_chng_seq { get; set; }
        public int ordr_itm_seq { get; set; }
        public int rcv_itm_seq { get; set; }
        public int ordr_seq { get; set; }
        public DateTime net_chng_date { get; set; }
        public double amt { get; set; }
    }
}
