using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_cm_count_var_dtl
    {
        public int store_id { get; set; }
        public int count_seq { get; set; }
        public int count_item_seq { get; set; }
        public decimal? base_variance_amt { get; set; }
        public decimal? frgn_variance_amt { get; set; }
        public decimal? base_system_amt { get; set; }
        public decimal? frgn_system_amt { get; set; }
    }
}
