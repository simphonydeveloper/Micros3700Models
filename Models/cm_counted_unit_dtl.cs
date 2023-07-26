using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cm_counted_unit_dtl
    {
        public int count_seq { get; set; }
        public int count_item_seq { get; set; }
        public int ref_count_unit_seq { get; set; }
        public int count_dtl_seq { get; set; }
        public decimal? base_count_amt { get; set; }
        public int? count_quantity { get; set; }
        public decimal? frgn_count_amt { get; set; }
        public string count_reference { get; set; }
        public string ob_adjustment { get; set; }
        public int? list_id { get; set; }
        public string adj_reason { get; set; }
    }
}
