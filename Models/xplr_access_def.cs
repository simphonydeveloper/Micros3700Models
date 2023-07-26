using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class xplr_access_def
    {
        public int emp_class_seq { get; set; }
        public int node_seq { get; set; }
        public short xplr_grp_access { get; set; }
    }
}
