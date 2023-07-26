using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class brk_def
    {
        public int brk_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public short? duration_before_brk { get; set; }
        public short? duration_of_brk { get; set; }
        public string ob_paid_brk { get; set; }
    }
}
