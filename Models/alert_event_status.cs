using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class alert_event_status
    {
        public int alert_event_seq { get; set; }
        public string device_source { get; set; }
        public string subject { get; set; }
        public string text_message { get; set; }
        public DateTime time_created_utc { get; set; }
        public DateTime? time_cleared_utc { get; set; }
        public int? cleared_by_emp_seq { get; set; }
        public int uws_alert_method { get; set; }
    }
}
