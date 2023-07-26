using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class rpt_viewer_lst_dtl
    {
        public int rpt_template_seq { get; set; }
        public int rpt_viewer_range_seq { get; set; }
        public int obj_type { get; set; }
        public int obj_seq { get; set; }
    }
}
