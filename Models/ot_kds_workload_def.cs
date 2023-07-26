using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class ot_kds_workload_def
    {
        public int ot_kds_workload_seq { get; set; }
        public int? obj_num { get; set; }
        public int order_type_seq { get; set; }
        public short? qty { get; set; }
        public short? minutes { get; set; }
    }
}
