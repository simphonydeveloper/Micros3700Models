using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class shift_rvc_team_ttl
    {
        public int store_id { get; set; }
        public int emp_seq { get; set; }
        public int shift_seq { get; set; }
        public int rvc_seq { get; set; }
        public int team_seq { get; set; }
        public int team_version_seq { get; set; }
        public decimal? gross_rcpts_ttl { get; set; }
        public decimal? charged_rcpts_ttl { get; set; }
        public decimal? tip_svc_ttl { get; set; }
        public decimal? chgd_tips_ttl { get; set; }
        public decimal? tips_decl_ttl { get; set; }
        public decimal? ind_tips_paid_ttl { get; set; }
        public decimal? tips_paid_ttl { get; set; }
        public int? em_ttl_repl_seq { get; set; }
        public decimal? emp_svc_tip_ttl { get; set; }
    }
}
