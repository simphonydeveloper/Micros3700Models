using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class tms_tbl_status
    {
        public int tbl_seq { get; set; }
        public string state { get; set; }
        public string ob_dirty { get; set; }
        public short? dining_course { get; set; }
        public short? estimated_available_time { get; set; }
        public int? parent_tbl_seq { get; set; }
        public short? num_seats { get; set; }
        public short? estimated_turn_time { get; set; }
        public string next_available { get; set; }
        public short? kds_course_alert_level { get; set; }
        public short? kds_course_peak_alert_level { get; set; }
    }
}
