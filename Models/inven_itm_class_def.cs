using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class inven_itm_class_def
    {
        public int inven_itm_class_seq { get; set; }
        public int? tax_class_seq { get; set; }
        public int? emp_class_seq { get; set; }
        public string name { get; set; }
        public int obj_num { get; set; }
        public string ob_usage_rpt { get; set; }
        public string ob_sold_as_retail { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public long? multi_user_access_seq { get; set; }
    }
}
