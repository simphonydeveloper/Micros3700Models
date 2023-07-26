using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class prod_sht_day_of_wk_def
    {
        public short day_of_week { get; set; }
        public int prod_sht_seq { get; set; }
        public int? par_lvl_seq { get; set; }
    }
}
