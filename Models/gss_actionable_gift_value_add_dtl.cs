using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_actionable_gift_value_add_dtl
    {
        public int gift_value_add_dtl_seq { get; set; }
        public int? check_num { get; set; }
        public DateTime? chk_open_tm { get; set; }
    }
}
