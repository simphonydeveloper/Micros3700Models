using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cm_reason_text_def
    {
        public int cm_reason_txt_seq { get; set; }
        public int? cm_reason_type { get; set; }
        public string reason_text { get; set; }
    }
}
