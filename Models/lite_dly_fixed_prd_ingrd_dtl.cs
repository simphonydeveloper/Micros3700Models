using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lite_dly_fixed_prd_ingrd_dtl
    {
        public int ingrd_seq { get; set; }
        public DateTime business_date { get; set; }
        public int fixed_period_seq { get; set; }
        public decimal? beginning_amount { get; set; }
        public decimal? delivery_amount { get; set; }
        public decimal? waste_amount { get; set; }
        public decimal? ending_amount { get; set; }
        public decimal? theoretical_amount { get; set; }
    }
}
