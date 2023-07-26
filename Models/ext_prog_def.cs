using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class ext_prog_def
    {
        public int ext_prog_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public string command_line { get; set; }
        public string current_dir { get; set; }
        public string run_style { get; set; }
        public string ob_run_in_separate_vm { get; set; }
        public string user_interface_type { get; set; }
        public string obj_type { get; set; }
        public string ob_accepts_date { get; set; }
        public string ob_accepts_rvc { get; set; }
        public string ob_accepts_obj { get; set; }
        public string ob_accepts_shift { get; set; }
        public string ob_accepts_store { get; set; }
        public string ob_accepts_rest_grp { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public string ob_show_alert_status { get; set; }
    }
}
