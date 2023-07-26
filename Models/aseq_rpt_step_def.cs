using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class aseq_rpt_step_def
    {
        public int aseq_seq { get; set; }
        public int aseq_step_seq { get; set; }
        public int? rpt_template_seq { get; set; }
        public string ob_preview_output { get; set; }
        public string title { get; set; }
        public string printer { get; set; }
        public string filename { get; set; }
        public int? last_updated_by { get; set; }
    }
}
