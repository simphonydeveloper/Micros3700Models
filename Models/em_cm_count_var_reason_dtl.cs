using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_cm_count_var_reason_dtl
    {
        public int store_id { get; set; }
        public int count_seq { get; set; }
        public int reason_dtl_seq { get; set; }
        public int? count_item_seq { get; set; }
        public string reason { get; set; }
    }
}
