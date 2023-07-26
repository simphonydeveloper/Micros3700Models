using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_bonus_def
    {
        public int bonus_seq { get; set; }
        public string name { get; set; }
        public int bonus_method { get; set; }
        public int reset_type { get; set; }
        public int period_type { get; set; }
        public int bonus_plan_seq { get; set; }
        public decimal? bonus_amount { get; set; }
        public DateTime? effective_date { get; set; }
        public DateTime? expire_date { get; set; }
        public string repeat_type { get; set; }
        public int? min_chk_value { get; set; }
        public int? bonus_threshold { get; set; }
    }
}
