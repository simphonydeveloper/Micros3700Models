using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class rcv_itm_adjmt_dtl
    {
        public int pslp_adjmt_seq { get; set; }
        public int ordr_itm_seq { get; set; }
        public int rcv_itm_seq { get; set; }
        public int ordr_seq { get; set; }
        public int pslp_seq { get; set; }
        public double? incl_adjmt_amt { get; set; }
        public double? excl_adjmt_amt { get; set; }
        public double? adjmt { get; set; }
        public double? adjmt_cost_amt { get; set; }
        public double? incl_adjmt_amt_base { get; set; }
        public double? excl_adjmt_amt_base { get; set; }
        public double? adjmt_base { get; set; }
        public double? adjmt_cost_amt_base { get; set; }
    }
}
