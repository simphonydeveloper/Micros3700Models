using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class unit_def
    {
        public int unit_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public string abbreviation { get; set; }
        public string ob_partial_unit_allowed { get; set; }
        public double? unit_max_qty { get; set; }
        public string unit_type { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public long? multi_user_access_seq { get; set; }
    }
}
