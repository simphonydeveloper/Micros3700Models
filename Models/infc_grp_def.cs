using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class infc_grp_def
    {
        public int infc_grp_seq { get; set; }
        public string name { get; set; }
        public string grp_desc { get; set; }
        public string ob_suppress_dup { get; set; }
    }
}
