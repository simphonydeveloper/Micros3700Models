using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class aseq_rpt_step_lst_def
    {
        public int aseq_seq { get; set; }
        public int aseq_step_seq { get; set; }
        public int rpt_itm_seq { get; set; }
        public int? lst_seq { get; set; }
        public string range_source { get; set; }
    }
}
