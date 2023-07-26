using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class hist_emp_eval_job_dtl
    {
        public int emp_seq { get; set; }
        public int emp_eval_seq { get; set; }
        public int hist_seq { get; set; }
        public int? job_seq { get; set; }
        public int? job_skill_seq { get; set; }
        public DateTime? eval_date { get; set; }
        public string eval_type { get; set; }
        public short? score { get; set; }
        public string ob_successful { get; set; }
        public int? evaluated_by { get; set; }
        public string comments { get; set; }
        public string cert_name { get; set; }
        public DateTime? due_date { get; set; }
        public int? change_by { get; set; }
        public DateTime? change_date { get; set; }
    }
}
