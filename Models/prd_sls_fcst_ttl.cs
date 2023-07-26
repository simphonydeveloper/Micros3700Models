using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class prd_sls_fcst_ttl
    {
        public DateTime bus_date { get; set; }
        public int mi_def_seq { get; set; }
        public int fcst_prd { get; set; }
        public decimal? fcst_qty { get; set; }
    }
}
