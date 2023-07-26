using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_evt_cat_def
    {
        public int evt_cat_seq { get; set; }
        public int? obj_num { get; set; }
        public string name { get; set; }
        public short? num_days_to_store { get; set; }
    }
}
