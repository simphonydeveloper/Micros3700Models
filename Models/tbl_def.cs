using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class tbl_def
    {
        public int tbl_seq { get; set; }
        public int obj_num { get; set; }
        public int rvc_seq { get; set; }
        public string name { get; set; }
        public int? tbl_obj_emp_seq { get; set; }
        public int? section_seq { get; set; }
        public short? tbl_obj_seated_icon_id { get; set; }
        public short? tbl_obj_alert1_icon_id { get; set; }
        public short? tbl_obj_alert2_icon_id { get; set; }
        public int? num_seats { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public int? tbl_obj_macro_seq { get; set; }
    }
}
