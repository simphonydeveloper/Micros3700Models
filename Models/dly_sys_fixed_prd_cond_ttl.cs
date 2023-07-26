using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class dly_sys_fixed_prd_cond_ttl
    {
        public DateTime business_date { get; set; }
        public int store_id { get; set; }
        public int fixed_period_seq { get; set; }
        public int mi_seq { get; set; }
        public int cond_mi_seq { get; set; }
        public int parent_menu_lvl { get; set; }
        public int ilcg_seq { get; set; }
        public int menu_lvl { get; set; }
        public int? sls_cnt { get; set; }
        public int? rtn_cnt { get; set; }
        public double? dsc_ttl { get; set; }
        public double? sls_ttl { get; set; }
        public double? cost_ttl { get; set; }
        public double? vat_ttl { get; set; }
        public int em_ttl_repl_seq { get; set; }
        public double? vat_dsc_ttl { get; set; }
    }
}
