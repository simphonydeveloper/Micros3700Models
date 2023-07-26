using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_recurring_deduction_def
    {
        public int recurring_deduction_seq { get; set; }
        public int emp_seq { get; set; }
        public int deduction_seq { get; set; }
        public decimal? deduction_amt { get; set; }
        public decimal? deduction_pctge { get; set; }
        public int? deduction_type { get; set; }
        public DateTime? effective_from_date { get; set; }
        public DateTime? effective_to_date { get; set; }
    }
}
