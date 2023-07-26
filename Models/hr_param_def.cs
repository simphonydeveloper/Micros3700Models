using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class hr_param_def
    {
        public int store_id { get; set; }
        public short? num_days_emp_eval { get; set; }
        public short? num_days_emp_rqst { get; set; }
        public short? num_days_emp_status_hist { get; set; }
        public short? num_days_store_hist { get; set; }
        public string alpha_01_caption { get; set; }
        public string alpha_02_caption { get; set; }
        public string alpha_03_caption { get; set; }
        public string alpha_04_caption { get; set; }
        public string alpha_05_caption { get; set; }
        public string alpha_06_caption { get; set; }
        public string alpha_07_caption { get; set; }
        public string alpha_08_caption { get; set; }
        public string numeric_01_caption { get; set; }
        public string numeric_02_caption { get; set; }
        public string numeric_03_caption { get; set; }
        public string numeric_04_caption { get; set; }
        public string numeric_05_caption { get; set; }
        public string numeric_06_caption { get; set; }
        public string numeric_07_caption { get; set; }
        public string numeric_08_caption { get; set; }
        public string other_area_code_caption { get; set; }
        public string other_local_num_caption { get; set; }
        public string ob_hr_intfc_enabled { get; set; }
        public int? min_emp_obj_num { get; set; }
        public int? max_emp_obj_num { get; set; }
        public short? num_days_store_term_emp { get; set; }
        public int? ssn_validation_type { get; set; }
        public short? lm_licensing { get; set; }
        public string ob_suppress_clk_out_on_rpt { get; set; }
        public string ob_rsvd01 { get; set; }
        public int? num_rsvd02 { get; set; }
        public string str_rsvd01 { get; set; }
        public short? num_days_job_rates { get; set; }
    }
}
