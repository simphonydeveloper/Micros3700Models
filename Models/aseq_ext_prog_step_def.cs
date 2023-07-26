using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class aseq_ext_prog_step_def
    {
        public int aseq_seq { get; set; }
        public int aseq_step_seq { get; set; }
        public int? ext_prog_seq { get; set; }
        public int? last_updated_by { get; set; }
    }
}
