using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_cm_emp_name_def
    {
        public int store_id { get; set; }
        public int emp_seq { get; set; }
        public int? obj_num { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
    }
}
