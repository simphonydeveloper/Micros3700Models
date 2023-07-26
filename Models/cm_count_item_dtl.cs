using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cm_count_item_dtl
    {
        public int count_item_seq { get; set; }
        public int ref_cm_item_seq { get; set; }
        public int? cm_item_type { get; set; }
        public int item_version { get; set; }
        public int? res_item_id { get; set; }
        public string cm_item_name { get; set; }
        public int? ref_cm_currency_seq { get; set; }
        public string ob_depositable { get; set; }
        public string ob_is_cash_pull_operation { get; set; }
    }
}
