using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_pending_ts_styles
    {
        public int ts_style_seq { get; set; }
        public int? template { get; set; }
    }
}
