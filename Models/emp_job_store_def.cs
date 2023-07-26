using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class emp_job_store_def
    {
        public int store_id { get; set; }
        public int emp_seq { get; set; }
        public int job_seq { get; set; }
        public string ob_primary_job { get; set; }
    }
}
