using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cncy_exch_rate_type_def
    {
        public int cncy_exch_rate_type_seq { get; set; }
        public int? lang_seq { get; set; }
        public string disp_name { get; set; }
    }
}
