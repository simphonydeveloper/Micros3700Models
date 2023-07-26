using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class mi_sls_fcst_dtl
    {
        public DateTime bus_date { get; set; }
        public int mi_def_seq { get; set; }
        public int? recipe_seq { get; set; }
        public int? mi_def_price_lvl { get; set; }
        public int? rvc_seq { get; set; }
    }
}
