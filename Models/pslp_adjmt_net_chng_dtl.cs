using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class pslp_adjmt_net_chng_dtl
    {
        public int pslp_adjmt_seq { get; set; }
        public int pslp_seq { get; set; }
        public int net_chng_seq { get; set; }
        public DateTime? net_chng_date { get; set; }
        public double? amt { get; set; }
    }
}
