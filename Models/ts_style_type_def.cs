using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class ts_style_type_def
    {
        public int ts_style_seq { get; set; }
        public string pos_type { get; set; }
        public short? height { get; set; }
        public short? width { get; set; }
        public short font { get; set; }
        public int? template { get; set; }
    }
}
