using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_customer_bonus_dtl
    {
        public int customer_bonus_dtl_seq { get; set; }
        public int customer_plan_dtl_seq { get; set; }
        public int bonus_seq { get; set; }
        public DateTime? last_reset_date { get; set; }
        public int? curr_points { get; set; }
        public int? curr_points_adj { get; set; }
        public int? hist_points { get; set; }
        public int? hist_points_adj { get; set; }
        public int? award_count { get; set; }
    }
}
