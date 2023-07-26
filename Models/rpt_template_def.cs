using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class rpt_template_def
    {
        public int rpt_template_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public int? rpt_class_seq { get; set; }
        public string template_file { get; set; }
        public string ob_40_column { get; set; }
        public string ob_hide_on_run_scrn { get; set; }
        public string ob_use_list { get; set; }
        public string product_mask { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public string ob_rpt_viewer { get; set; }
    }
}
