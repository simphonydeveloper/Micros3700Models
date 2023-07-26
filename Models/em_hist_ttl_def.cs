using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_hist_ttl_def
    {
        public int hist_ttl_seq { get; set; }
        public int? num_of_days { get; set; }
    }
}
