using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class fed_state_lab_law_def
    {
        public int fed_state_law_seq { get; set; }
        public string state { get; set; }
        public decimal min_wg_reg_emp { get; set; }
        public decimal? tipped_credit_amt { get; set; }
        public decimal? tipped_credit_pct { get; set; }
        public int? otm_rule_seq { get; set; }
        public short? min_hrs_pay { get; set; }
        public short? min_hrs_paid { get; set; }
        public DateTime? min_wage_effective_datetime { get; set; }
    }
}
