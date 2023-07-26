using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class prod_sht_def
    {
        public int prod_sht_seq { get; set; }
        public string name { get; set; }
        public int obj_num { get; set; }
        public string cmnt_ln { get; set; }
        public int? prod_sht_class_seq { get; set; }
        public int? par_lvl_seq { get; set; }
        public string spreadsheet_file_name_ovrde { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
