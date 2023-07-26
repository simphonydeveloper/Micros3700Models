using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class aseq_sp_step_parm_def
    {
        public int aseq_seq { get; set; }
        public int aseq_step_seq { get; set; }
        public int stored_proc_parm_seq { get; set; }
        public string parm_value_source { get; set; }
        public decimal? parm_numeric_value { get; set; }
        public string parm_string_value { get; set; }
        public int? last_updated_by { get; set; }
    }
}
