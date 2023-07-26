using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class dly_kds_fixed_prd_ttl
    {
        public DateTime business_date { get; set; }
        public int fixed_period_seq { get; set; }
        public int store_id { get; set; }
        public int em_ttl_repl_seq { get; set; }
        public int? app_cnt { get; set; }
        public int? non_app_cnt { get; set; }
        public int? app_prep_ttl_sec { get; set; }
        public int? non_app_prep_ttl_sec { get; set; }
        public int? app_alert1_cnt { get; set; }
        public int? non_app_alert1_cnt { get; set; }
        public int? app_alert2_cnt { get; set; }
        public int? non_app_alert2_cnt { get; set; }
        public int? signed_in_emp { get; set; }
    }
}
