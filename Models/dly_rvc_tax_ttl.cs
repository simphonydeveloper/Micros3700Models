using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class dly_rvc_tax_ttl
    {
        public DateTime business_date { get; set; }
        public int store_id { get; set; }
        public int rvc_seq { get; set; }
        public int tax_rate_seq { get; set; }
        public decimal coll_ttl { get; set; }
        public decimal txbl_sls_ttl { get; set; }
        public decimal exempt_ttl { get; set; }
        public int em_ttl_repl_seq { get; set; }
        public decimal? incl_tax_by_chk_itmzr_ttl { get; set; }
    }
}
