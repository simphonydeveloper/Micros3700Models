using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class emp_uws_status
    {
        public int uws_seq { get; set; }
        public int emp_seq { get; set; }
        public int? color_scheme_seq { get; set; }
        public short? cntrst_val { get; set; }
    }
}
