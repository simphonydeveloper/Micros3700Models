using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_lab_reqmnt_mtx_dtl
    {
        public int job_seq { get; set; }
        public DateTime sched_date { get; set; }
        public string ob_tm_indtrmt { get; set; }
        public int? mtx_seq { get; set; }
        public string ob_unapproved_fcst { get; set; }
    }
}
