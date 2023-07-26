using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class invc_net_chng_dtl
    {
        public int net_chng_seq { get; set; }
        public int invc_seq { get; set; }
        public DateTime net_chng_date { get; set; }
        public double amt { get; set; }
        public int? aprvd_by { get; set; }
        public DateTime? aprvd_date { get; set; }
    }
}
