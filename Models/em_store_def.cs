using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_store_def
    {
        public int store_seq { get; set; }
        public int enterprise_seq { get; set; }
        public string name { get; set; }
        public int? obj_num { get; set; }
        public string store_type { get; set; }
        public int? ob_active { get; set; }
        public string license_code { get; set; }
        public string address_lines { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postal_code { get; set; }
        public string country { get; set; }
        public string phone_1 { get; set; }
        public string phone_2 { get; set; }
        public string alternate_name_1 { get; set; }
        public string alternate_name_2 { get; set; }
        public string user_defined_1 { get; set; }
        public string user_defined_2 { get; set; }
        public string user_defined_3 { get; set; }
        public string user_defined_4 { get; set; }
        public string user_defined_5 { get; set; }
        public int? res_store_id_mapping { get; set; }
        public int? col_trans_seq { get; set; }
        public int? version_seq { get; set; }
    }
}
