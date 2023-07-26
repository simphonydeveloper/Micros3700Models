using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class emp_rqst_dtl
    {
        public int emp_seq { get; set; }
        public int emp_rqst_seq { get; set; }
        public int? reason_seq { get; set; }
        public DateTime? start_date { get; set; }
        public TimeSpan? start_time { get; set; }
        public DateTime? stop_date { get; set; }
        public TimeSpan? stop_time { get; set; }
        public DateTime rqst_date { get; set; }
        public short? avail_type { get; set; }
        public string decision { get; set; }
        public int? decision_by { get; set; }
        public DateTime? decision_date { get; set; }
    }
}
