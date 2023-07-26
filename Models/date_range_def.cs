using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class date_range_def
    {
        public int date_range_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public string start_range_date_type { get; set; }
        public short? start_range_year_offset { get; set; }
        public short? start_range_month_offset { get; set; }
        public short? start_range_day_offset { get; set; }
        public short? start_range_period_offset { get; set; }
        public DateTime? start_range_specified_date { get; set; }
        public string end_range_date_type { get; set; }
        public short? end_range_year_offset { get; set; }
        public short? end_range_month_offset { get; set; }
        public short? end_range_day_offset { get; set; }
        public short? end_range_period_offset { get; set; }
        public DateTime? end_range_specified_date { get; set; }
        public string range_type_name { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
