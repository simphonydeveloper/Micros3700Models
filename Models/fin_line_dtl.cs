using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class fin_line_dtl
    {
        public int fin_prd_seq { get; set; }
        public int fin_config_seq { get; set; }
        public int fin_line_seq { get; set; }
        public int store_id { get; set; }
        public double? actual { get; set; }
        public double? actual_cnt { get; set; }
        public double? budget { get; set; }
        public double? projected { get; set; }
        public string actual_text { get; set; }
        public string actual_cnt_text { get; set; }
        public string budget_text { get; set; }
        public string projected_text { get; set; }
        public string rsvd_01 { get; set; }
        public string rsvd_02 { get; set; }
        public string rsvd_03 { get; set; }
        public string rsvd_04 { get; set; }
        public int em_ttl_repl_seq { get; set; }
    }
}
