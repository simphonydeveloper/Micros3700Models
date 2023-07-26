using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class tms_quick_wait_quote_def
    {
        public int seq { get; set; }
        public short? quote_time_min { get; set; }
    }
}
