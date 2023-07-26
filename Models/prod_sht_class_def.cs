using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class prod_sht_class_def
    {
        public int prod_sht_class_seq { get; set; }
        public string name { get; set; }
        public int obj_num { get; set; }
        public short? reqmnt_mthd { get; set; }
        public string ob_prod_type { get; set; }
        public string ob_prn_cmnt { get; set; }
        public short? prod_horizon_num_day { get; set; }
        public string spreadsheet_file_name { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
