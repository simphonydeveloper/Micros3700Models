using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class dining_course_def
    {
        public int dining_course_seq { get; set; }
        public string name { get; set; }
        public int? min_prep_time { get; set; }
        public int? max_prep_time { get; set; }
        public int? course_color { get; set; }
        public short? course_icon_id { get; set; }
    }
}
