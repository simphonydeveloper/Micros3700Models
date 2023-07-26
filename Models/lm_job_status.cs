using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_job_status
    {
        public int job_seq { get; set; }
        public int? job_tmpl_seq { get; set; }
        public decimal? average_wg_per_job { get; set; }
        public string ob_active { get; set; }
    }
}
