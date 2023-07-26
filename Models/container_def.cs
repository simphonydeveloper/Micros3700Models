using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class container_def
    {
        public int container_seq { get; set; }
        public int? obj_num { get; set; }
        public string container_desc { get; set; }
        public string ob_returnable { get; set; }
        public decimal? empty_wght { get; set; }
        public int? pur_unit { get; set; }
        public double? cost { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
