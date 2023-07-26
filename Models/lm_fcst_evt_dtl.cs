using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_fcst_evt_dtl
    {
        public int evt_seq { get; set; }
        public int? obj_num { get; set; }
        public string name { get; set; }
        public int evt_type_seq { get; set; }
        public DateTime evt_date { get; set; }
    }
}
