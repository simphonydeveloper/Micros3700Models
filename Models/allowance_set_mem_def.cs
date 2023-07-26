using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class allowance_set_mem_def
    {
        public int allowance_set_mem_seq { get; set; }
        public int allowance_set_seq { get; set; }
        public string itm_type { get; set; }
        public int itm_seq { get; set; }
        public int? unit_seq { get; set; }
        public int? allowance_seq { get; set; }
        public int? ilcg_seq { get; set; }
    }
}
