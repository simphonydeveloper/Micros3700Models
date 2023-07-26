using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class allowance_itm_ttl
    {
        public int store_id { get; set; }
        public int allowance_itm_ttl_seq { get; set; }
        public string rollup_type { get; set; }
        public DateTime rollup_date { get; set; }
        public int? allowance_seq { get; set; }
        public int? ilcg_seq { get; set; }
        public int itm_seq { get; set; }
        public int? unit_seq { get; set; }
        public double qty { get; set; }
        public int em_ttl_repl_seq { get; set; }
    }
}
