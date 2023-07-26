using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class rpt_tmpl_lst_def
    {
        public int rpt_template_seq { get; set; }
        public int rpt_itm_seq { get; set; }
        public short obj_type { get; set; }
    }
}
