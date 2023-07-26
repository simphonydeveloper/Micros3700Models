using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_hist_ttl_dep_dtl
    {
        public int hist_ttl_dep_seq { get; set; }
        public int hist_ttl_seq { get; set; }
        public string published_data_path { get; set; }
    }
}
