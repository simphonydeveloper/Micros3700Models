using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class sched_class_def
    {
        public int sched_class_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public short? start_time { get; set; }
        public short? end_time { get; set; }
        public int? repeat_period { get; set; }
        public string sched_date_type { get; set; }
        public string ob_active_sun { get; set; }
        public string ob_active_mon { get; set; }
        public string ob_active_tue { get; set; }
        public string ob_active_wed { get; set; }
        public string ob_active_thu { get; set; }
        public string ob_active_fri { get; set; }
        public string ob_active_sat { get; set; }
        public DateTime? biweekly_start_date { get; set; }
        public short? day_of_month_1 { get; set; }
        public short? day_of_month_2 { get; set; }
        public short? day_of_month_3 { get; set; }
        public short? day_of_month_4 { get; set; }
        public short? month_of_year_1 { get; set; }
        public short? month_of_year_2 { get; set; }
        public short? month_of_year_3 { get; set; }
        public short? month_of_year_4 { get; set; }
        public DateTime? specified_date { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
