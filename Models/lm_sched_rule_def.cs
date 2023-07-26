using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_sched_rule_def
    {
        public int sched_rule_seq { get; set; }
        public int? obj_num { get; set; }
        public string name { get; set; }
        public string ob_ftm_first { get; set; }
        public string ob_average_wg_per_job { get; set; }
        public string ob_use_lab_reqmnt { get; set; }
        public string ob_sched_otm { get; set; }
        public string ob_sched_over_max_day_hrs { get; set; }
        public string ob_sched_over_max_day { get; set; }
        public string ob_sched_oncall { get; set; }
        public string ob_sched_over_min_btwn_shf { get; set; }
        public int? min_ftm_shf_len { get; set; }
        public int? min_ptm_shf_len { get; set; }
        public int? min_btwn_shf_len { get; set; }
        public int? idl_shf_ftm { get; set; }
        public int? idl_shf_ptm { get; set; }
        public short pool_qtr { get; set; }
        public short? sched_prd { get; set; }
        public short? sched_intv { get; set; }
        public short? emp_senior_prty { get; set; }
        public short? min_otm_prty { get; set; }
        public short? emp_preference_prty { get; set; }
        public short? equal_dstrb_prty { get; set; }
        public short? max_skl_prty { get; set; }
        public short? min_pay_prty { get; set; }
    }
}
