using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class dly_prod_sht_mem_dtl
    {
        public int prod_sht_seq { get; set; }
        public int inven_itm_seq { get; set; }
        public DateTime bus_date { get; set; }
        public int? reqmnt_unit_seq { get; set; }
        public decimal? min_qty { get; set; }
        public decimal? build_qty { get; set; }
    }
}
