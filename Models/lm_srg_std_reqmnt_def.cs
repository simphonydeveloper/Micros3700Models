using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_srg_std_reqmnt_def
    {
        public int srg_std_reqmnt_seq { get; set; }
        public int srg_std_seq { get; set; }
        public decimal std { get; set; }
        public int reqmnt { get; set; }
    }
}
