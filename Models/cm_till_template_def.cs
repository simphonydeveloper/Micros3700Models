using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cm_till_template_def
    {
        public int till_template_seq { get; set; }
        public string till_name { get; set; }
        public decimal? default_starting_amount { get; set; }
        public int? cm_accounting_method { get; set; }
        public decimal? cash_pull_threshold { get; set; }
        public int? cash_pull_alert { get; set; }
        public int? num_cash_pull_chits_to_print { get; set; }
        public int? starting_amount_deposited { get; set; }
        public int? countsheet_seq { get; set; }
        public decimal? cash_pull_threshold_2 { get; set; }
        public decimal? cash_pull_threshold_3 { get; set; }
    }
}
