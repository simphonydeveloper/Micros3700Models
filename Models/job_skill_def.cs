using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class job_skill_def
    {
        public int job_skill_seq { get; set; }
        public int? obj_num { get; set; }
        public string name { get; set; }
    }
}
