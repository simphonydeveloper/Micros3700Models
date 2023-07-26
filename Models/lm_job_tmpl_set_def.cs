using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_job_tmpl_set_def
    {
        public int job_tmpl_set_seq { get; set; }
        public string name { get; set; }
        public string ob_default { get; set; }
    }
}
