using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_job_task_status
    {
        public int job_task_seq { get; set; }
        public int job_seq { get; set; }
        public string ob_active { get; set; }
    }
}
