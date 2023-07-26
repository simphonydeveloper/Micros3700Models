using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class xplr_usr_state_dtl
    {
        public int node_seq { get; set; }
        public int emp_seq { get; set; }
        public short ob_open { get; set; }
        public short ob_cloaked { get; set; }
        public short ob_current { get; set; }
    }
}
