using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class color_scheme_def
    {
        public int color_scheme_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public string ob_cs01_mono { get; set; }
        public short? num_color_bits { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
