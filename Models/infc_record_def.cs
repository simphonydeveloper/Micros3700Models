using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class infc_record_def
    {
        public int infc_record_seq { get; set; }
        public int? infc_infc_seq { get; set; }
        public string name { get; set; }
        public string delimiter { get; set; }
        public int? prty_num { get; set; }
        public string output_format { get; set; }
        public string output_type { get; set; }
        public string ob_dynamic { get; set; }
        public string sql { get; set; }
        public int? query_type { get; set; }
        public string ob_incl_in_record_cnt { get; set; }
        public string ob_parameter_input { get; set; }
        public string ob_incl_in_record_set { get; set; }
    }
}
