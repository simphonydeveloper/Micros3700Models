using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class dly_rvc_fam_grp_ttl
    {
        public DateTime business_date { get; set; }
        public int store_id { get; set; }
        public int rvc_seq { get; set; }
        public int fam_grp_seq { get; set; }
        public int sls_cnt { get; set; }
        public double sls_ttl { get; set; }
        public int rtn_cnt { get; set; }
        public double rtn_ttl { get; set; }
        public double dsc_ttl { get; set; }
        public int em_ttl_repl_seq { get; set; }
        public decimal? suppressed_sls_ttl { get; set; }
    }
}
