using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class fin_profile_def
    {
        public int fin_profile_seq { get; set; }
        public int fin_config_seq { get; set; }
        public int? emp_bo_class_seq { get; set; }
        public string name { get; set; }
        public string no_pjt_copy { get; set; }
        public string force_close_current { get; set; }
        public string allow_close_today { get; set; }
        public int? warn_if_open { get; set; }
        public string maximize_on_start { get; set; }
        public string no_welcome_tab { get; set; }
        public string config_mode { get; set; }
        public string no_future { get; set; }
        public string no_closed { get; set; }
        public string no_open { get; set; }
        public string setup_mode { get; set; }
        public string rsvd_01 { get; set; }
        public string rsvd_02 { get; set; }
        public string rsvd_03 { get; set; }
        public string rsvd_04 { get; set; }
        public string rsvd_05 { get; set; }
        public string rsvd_06 { get; set; }
        public string rsvd_07 { get; set; }
        public string rsvd_08 { get; set; }
        public string rsvd_09 { get; set; }
        public string rsvd_10 { get; set; }
        public string no_min_max { get; set; }
        public string recalc_on_start { get; set; }
        public string partial_recalc { get; set; }
        public string recalc_on_finish { get; set; }
        public string read_only { get; set; }
        public int? user_link { get; set; }
        public string ob_vndr_access { get; set; }
    }
}
