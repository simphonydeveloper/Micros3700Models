using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_time_series_def
    {
        public int time_series_seq { get; set; }
        public int? import_seq { get; set; }
        public int? obj_num { get; set; }
        public string name { get; set; }
        public string tbl_name { get; set; }
        public string attribute { get; set; }
        public int? alt_seq_1 { get; set; }
        public string alt_seq_def_name_1 { get; set; }
        public int? alt_seq_2 { get; set; }
        public string alt_seq_def_name_2 { get; set; }
        public int? alt_seq_3 { get; set; }
        public string alt_seq_def_name_3 { get; set; }
        public int? mtx_seq { get; set; }
        public short? mtx_prd { get; set; }
        public short? mtx_intv { get; set; }
        public short? num_days_to_store { get; set; }
    }
}
