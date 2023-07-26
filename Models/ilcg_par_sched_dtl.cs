using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class ilcg_par_sched_dtl
    {
        public int ilcg_par_sched_dtl_seq { get; set; }
        public DateTime eff_date { get; set; }
        public byte? status { get; set; }
        public int ilcg_seq { get; set; }
        public int ilcg_par_sched_seq { get; set; }
        public int par_lvl_seq { get; set; }
    }
}
