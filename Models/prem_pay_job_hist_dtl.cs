using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class prem_pay_job_hist_dtl
    {
        public int hist_seq { get; set; }
        public int prem_pay_seq { get; set; }
        public int job_seq { get; set; }
        public string active_flag { get; set; }
        public DateTime? active_from_date { get; set; }
        public int? last_updated_by { get; set; }
    }
}
