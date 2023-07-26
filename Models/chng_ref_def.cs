using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class chng_ref_def
    {
        public int chng_ref_seq { get; set; }
        public int obj_num { get; set; }
        public string code { get; set; }
        public string table_name { get; set; }
        public string column_name { get; set; }
        public string description { get; set; }
    }
}
