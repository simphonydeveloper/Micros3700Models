using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cc_batch_dtl
    {
        public int batch_seq { get; set; }
        public DateTime business_date { get; set; }
        public int driver_seq { get; set; }
        public DateTime creation_time { get; set; }
        public int? creation_emp_seq { get; set; }
        public DateTime? edit_time { get; set; }
        public int? edit_emp_seq { get; set; }
        public DateTime? done_settle_time { get; set; }
        public int? done_settle_emp_seq { get; set; }
        public string processor_batch_ref { get; set; }
    }
}
