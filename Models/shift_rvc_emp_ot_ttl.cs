using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class shift_rvc_emp_ot_ttl
    {
        public int store_id { get; set; }
        public int emp_seq { get; set; }
        public int shift_seq { get; set; }
        public int order_type_seq { get; set; }
        public int rvc_seq { get; set; }
        public decimal net_sls_ttl { get; set; }
        public int chk_cnt { get; set; }
        public int cov_cnt { get; set; }
        public int tbl_turn_cnt { get; set; }
        public int tbl_dine_time { get; set; }
        public int em_ttl_repl_seq { get; set; }
    }
}
