using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class prem_pay_ttl
    {
        public int emp_seq { get; set; }
        public int pp_hist_seq { get; set; }
        public int time_card_seq { get; set; }
        public DateTime clk_in_date_tm { get; set; }
        public DateTime? clk_out_date_tm { get; set; }
        public int? prem_pay_sec { get; set; }
        public decimal? prem_pay_rate { get; set; }
    }
}
