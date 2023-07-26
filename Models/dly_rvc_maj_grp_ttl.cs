using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class dly_rvc_maj_grp_ttl
    {
        public DateTime business_date { get; set; }
        public int store_id { get; set; }
        public int rvc_seq { get; set; }
        public int maj_grp_seq { get; set; }
        public int sls_cnt { get; set; }
        public decimal sls_ttl { get; set; }
        public int rtn_cnt { get; set; }
        public decimal rtn_ttl { get; set; }
        public decimal dsc_ttl { get; set; }
        public int em_ttl_repl_seq { get; set; }
        public decimal? suppressed_sls_ttl { get; set; }
    }
}
