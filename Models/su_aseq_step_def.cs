using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class su_aseq_step_def
    {
        public int su_aseq_seq { get; set; }
        public int su_aseq_step_seq { get; set; }
        public short? rpt_num { get; set; }
        public short? range_type { get; set; }
        public short? scope { get; set; }
        public short? period { get; set; }
        public short? reset { get; set; }
        public short omit_zeros { get; set; }
        public short? printer { get; set; }
        public int? range_start { get; set; }
        public int? range_end { get; set; }
        public string ob_suas01_run_unsupervised { get; set; }
        public string ob_suas02_lock_other_sus { get; set; }
        public short? scope_value { get; set; }
        public int? last_updated_by { get; set; }
    }
}
