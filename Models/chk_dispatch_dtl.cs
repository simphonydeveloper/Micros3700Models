using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class chk_dispatch_dtl
    {
        public int chk_seq { get; set; }
        public DateTime? sent_tm { get; set; }
        public DateTime? auto_promise_tm { get; set; }
        public DateTime? user_promise_tm { get; set; }
        public DateTime? kds_start_tm { get; set; }
        public DateTime? kds_prep_done_tm { get; set; }
        public DateTime? kds_expo_done_tm { get; set; }
        public int? dispatch_uws_seq { get; set; }
        public DateTime? dispatch_tm { get; set; }
        public int? driver_emp_seq { get; set; }
        public DateTime? undispatch_tm { get; set; }
        public DateTime? approx_delv_tm { get; set; }
        public DateTime? driver_return_tm { get; set; }
        public UInt16? minimum_prep_seconds { get; set; }
        public UInt16? expected_drive_minutes { get; set; }
        public UInt16? prep_adjust_seconds { get; set; }
        public UInt16? expo_tray_num { get; set; }
        public UInt16? expo_tray_pos { get; set; }
        public DateTime? lock_dispatch_tm { get; set; }
        public DateTime? call_begun_tm { get; set; }
        public DateTime? call_answer_tm { get; set; }
        public DateTime? expecting_tm { get; set; }
        public DateTime? last_update_tm { get; set; }
        public DateTime? business_date { get; set; }
        public UInt32 chk_version { get; set; }
        public int? expo_tray_area_seq { get; set; }
        public string lock_app_id { get; set; }
        public DateTime? greeted_tm { get; set; }
    }
}
