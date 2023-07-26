using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class ilcg_stat
    {
        public int ilcg_seq { get; set; }
        public int? xfer_num_seed { get; set; }
    }
}
