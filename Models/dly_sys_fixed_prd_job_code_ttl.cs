using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class dly_sys_fixed_prd_job_code_ttl
    {
        public DateTime business_date { get; set; }
        public int fixed_period_seq { get; set; }
        public int store_id { get; set; }
        public int job_seq { get; set; }
        public int job_cat_seq { get; set; }
        public decimal? reg_hrs { get; set; }
        public decimal? reg_ttl { get; set; }
        public decimal? ovt_hrs { get; set; }
        public decimal? ovt_ttl { get; set; }
        public decimal? non_rvc_reg_hrs { get; set; }
        public decimal? non_rvc_reg_ttl { get; set; }
        public decimal? non_rvc_ovt_hrs { get; set; }
        public decimal? non_rvc_ovt_ttl { get; set; }
    }
}
