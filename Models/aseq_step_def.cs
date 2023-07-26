using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class aseq_step_def
    {
        public int aseq_seq { get; set; }
        public int aseq_step_seq { get; set; }
        public string step_type { get; set; }
        public string ob_skip_step { get; set; }
        public string date_range_source { get; set; }
        public int? date_range_seq { get; set; }
        public string rvc_range_source { get; set; }
        public int? rvc_range_begin_obj_num { get; set; }
        public int? rvc_range_end_obj_num { get; set; }
        public string obj_range_source { get; set; }
        public int? obj_range_begin_obj_num { get; set; }
        public int? obj_range_end_obj_num { get; set; }
        public string shift_range_source { get; set; }
        public string store_range_source { get; set; }
        public int? store_range_begin_obj_num { get; set; }
        public int? store_range_end_obj_num { get; set; }
        public string rest_grp_range_source { get; set; }
        public int? rest_grp_range_begin_obj_num { get; set; }
        public int? rest_grp_range_end_obj_num { get; set; }
        public string error_action { get; set; }
        public int? error_branch_aseq_seq { get; set; }
        public int? error_branch_aseq_step_seq { get; set; }
        public string error_message { get; set; }
        public string ob_rsvd01 { get; set; }
        public string ob_rsvd02 { get; set; }
        public string ob_rsvd03 { get; set; }
        public string comments { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
