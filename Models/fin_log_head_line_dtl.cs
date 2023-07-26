using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class fin_log_head_line_dtl
    {
        public int fin_log_lineref_seq { get; set; }
        public int fin_log_headref_seq { get; set; }
    }
}
