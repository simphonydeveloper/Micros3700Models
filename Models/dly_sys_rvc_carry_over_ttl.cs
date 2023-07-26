using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class dly_sys_rvc_carry_over_ttl
    {
        public int store_id { get; set; }
        public DateTime business_date { get; set; }
        public int rvc_seq { get; set; }
        public int? chk_carry_over_cnt { get; set; }
        public decimal? chk_carry_over_ttl { get; set; }
        public int? em_ttl_repl_seq { get; set; }
    }
}
