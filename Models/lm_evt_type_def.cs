using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_evt_type_def
    {
        public int evt_type_seq { get; set; }
        public int? obj_num { get; set; }
        public string name { get; set; }
        public int evt_cat_seq { get; set; }
    }
}
