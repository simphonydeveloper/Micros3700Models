using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class caedc_driver_def
    {
        public int driver_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public string driver_code { get; set; }
        public int max_batch_size { get; set; }
        public string ob_include_zero_pymnt_recs { get; set; }
        public int? sys_num01 { get; set; }
        public int? sys_num02 { get; set; }
        public int? sys_num03 { get; set; }
        public int? sys_num04 { get; set; }
        public int? sys_num05 { get; set; }
        public int? sys_num06 { get; set; }
        public int? sys_num07 { get; set; }
        public int? sys_num08 { get; set; }
        public int? sys_num09 { get; set; }
        public int? sys_num10 { get; set; }
        public string sys_str01 { get; set; }
        public string sys_str02 { get; set; }
        public string sys_str03 { get; set; }
        public string sys_str04 { get; set; }
        public string sys_str05 { get; set; }
        public string sys_str06 { get; set; }
        public string sys_str07 { get; set; }
        public string sys_str08 { get; set; }
        public string sys_str09 { get; set; }
        public string sys_str10 { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public string ob_multi_merch { get; set; }
    }
}
