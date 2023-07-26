using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class if_pos_sls_ttl
    {
        public int pos_trans_seq { get; set; }
        public decimal nlu_num { get; set; }
        public DateTime bus_date { get; set; }
        public short cnt { get; set; }
        public string error { get; set; }
    }
}
