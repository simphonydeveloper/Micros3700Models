using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class su_reset_dtl
    {
        public int su_reset_seq { get; set; }
        public int? store_id { get; set; }
        public int? uws_seq { get; set; }
        public string reset_type { get; set; }
        public DateTime? reset_date_time { get; set; }
        public DateTime? last_reset_date_time { get; set; }
        public short? z_counter { get; set; }
        public decimal? grand_total { get; set; }
        public int? run_by_emp_seq { get; set; }
        public string ob_master_key_used { get; set; }
    }
}
