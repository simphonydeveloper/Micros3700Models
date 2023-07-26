using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class trans_dtl
    {
        public int trans_seq { get; set; }
        public string type { get; set; }
        public int? chk_seq { get; set; }
        public int rvc_seq { get; set; }
        public int? chk_emp_seq { get; set; }
        public int? chk_emp_shift_seq { get; set; }
        public int? trans_emp_seq { get; set; }
        public int? trans_emp_shift_seq { get; set; }
        public int? job_seq { get; set; }
        public int? cshr_ttl_seq { get; set; }
        public int? cshr_ttl_shift_seq { get; set; }
        public DateTime business_date { get; set; }
        public string ob_outside_business_date { get; set; }
        public int? fixed_period_seq { get; set; }
        public DateTime start_date_tm { get; set; }
        public DateTime end_date_tm { get; set; }
        public int? srv_period_seq { get; set; }
        public int training_status { get; set; }
        public string ob_closed_check_edit { get; set; }
        public int uws_seq { get; set; }
        public short uws_trans_num { get; set; }
        public int? standalone_trans_seq { get; set; }
        public int? round { get; set; }
        public int? open_on_sys_uws_seq { get; set; }
        public string kds_trans_id { get; set; }
        public string creation_mode { get; set; }
        public string ob_chk_reopened { get; set; }
        public string ob_rsvd01 { get; set; }
        public string ob_rsvd02 { get; set; }
        public string ob_rsvd03 { get; set; }
        public string ob_rsvd04 { get; set; }
        public int? team_seq { get; set; }
        public int? team_version_seq { get; set; }
        public int? cm_till_id { get; set; }
        public short? rf_signal_strength { get; set; }
        public short? battery_life { get; set; }
    }
}
