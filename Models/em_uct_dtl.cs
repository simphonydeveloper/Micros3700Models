using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_uct_dtl
    {
        public int col_trans_seq { get; set; }
        public string host_name { get; set; }
        public string ob_drop_packet { get; set; }
    }
}
