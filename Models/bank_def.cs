using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class bank_def
    {
        public int bank_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public string building_society_roll_num { get; set; }
        public string addr_ln_1 { get; set; }
        public string addr_ln_2 { get; set; }
        public string city { get; set; }
        public string county { get; set; }
        public string state { get; set; }
        public string cntry { get; set; }
        public string postal_code { get; set; }
        public string EM_GUID { get; set; }
    }
}
