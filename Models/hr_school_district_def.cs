using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class hr_school_district_def
    {
        public int school_district_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public string county { get; set; }
        public string state { get; set; }
        public string cntry { get; set; }
        public string EM_GUID { get; set; }
    }
}
