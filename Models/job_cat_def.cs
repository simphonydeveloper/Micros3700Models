using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class job_cat_def
    {
        public int job_cat_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public int? work_hrs_seq { get; set; }
        public int? fcst_ele_seq { get; set; }
        public int? time_series_seq { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
