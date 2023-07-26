using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class task_state_def
    {
        public int task_state_seq { get; set; }
        public int rvc_seq { get; set; }
        public int task_seq { get; set; }
        public short start_day_of_week { get; set; }
        public TimeSpan start_time { get; set; }
        public string enabled { get; set; }
        public int occurrence_period_min { get; set; }
        public int occurrence_period_max { get; set; }
        public double assignment_urgency_factor { get; set; }
        public short? num_employees_assigned_max { get; set; }
        public int duration { get; set; }
        public byte priority { get; set; }
    }
}
