using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class pm_waste_dtl
    {
        public int dtl_seq { get; set; }
        public int waste_seq { get; set; }
        public int mi_seq { get; set; }
        public short quantity { get; set; }
        public int price_lvl { get; set; }
        public DateTime business_date { get; set; }
        public DateTime trans_date { get; set; }
        public decimal? item_weight { get; set; }
        public double? amt { get; set; }
        public double? cost { get; set; }
        public int? waste_reason_seq { get; set; }
    }
}
