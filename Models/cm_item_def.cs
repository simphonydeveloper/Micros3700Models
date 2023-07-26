using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cm_item_def
    {
        public int cm_item_seq { get; set; }
        public string cm_item_name { get; set; }
        public int? res_item_id { get; set; }
        public int? cm_currency_seq { get; set; }
        public int? cm_item_type { get; set; }
        public string ob_countable { get; set; }
        public string ob_negative { get; set; }
        public string ob_depositable { get; set; }
        public string ob_add_to_cash_pull_accumulator { get; set; }
        public int item_version { get; set; }
        public string ob_is_cash_pull_operation { get; set; }
    }
}
