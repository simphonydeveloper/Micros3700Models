using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class rpt_viewer_range_def
    {
        public int rpt_template_seq { get; set; }
        public int rpt_viewer_range_seq { get; set; }
        public string range_description { get; set; }
        public int? date_range_seq { get; set; }
        public string shift_code { get; set; }
        public int? rvc_begin { get; set; }
        public int? rvc_end { get; set; }
        public int? cshr_begin { get; set; }
        public int? cshr_end { get; set; }
        public int? emp_begin { get; set; }
        public int? emp_end { get; set; }
        public int? mi_begin { get; set; }
        public int? mi_end { get; set; }
        public int? mi_grp_begin { get; set; }
        public int? mi_grp_end { get; set; }
        public int? srv_prd_begin { get; set; }
        public int? srv_prd_end { get; set; }
        public int? tm_prd_begin { get; set; }
        public int? tm_prd_end { get; set; }
        public int? store_begin { get; set; }
        public int? store_end { get; set; }
        public int? store_grp_begin { get; set; }
        public int? store_grp_end { get; set; }
    }
}
