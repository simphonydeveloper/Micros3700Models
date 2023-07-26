using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class xplr_itm_def
    {
        public int node_seq { get; set; }
        public short data_type { get; set; }
        public int data_seq { get; set; }
    }
}
