using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class infc_grp_mem_def
    {
        public int infc_grp_mem_seq { get; set; }
        public int? prty_num { get; set; }
        public int? infc_parent_grp_seq { get; set; }
        public int? infc_mem_grp_seq { get; set; }
        public int? infc_mem_infc_seq { get; set; }
    }
}
