using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_ar_terms_def
    {
        public int ar_terms_seq { get; set; }
        public DateTime creation_date { get; set; }
        public int? emp_seq { get; set; }
        public string description { get; set; }
        public int term_period { get; set; }
        public int term_period_type { get; set; }
        public int term_period_start { get; set; }
        public int term_percent { get; set; }
        public decimal min_amt { get; set; }
    }
}
