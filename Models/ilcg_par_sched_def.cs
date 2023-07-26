using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class ilcg_par_sched_def
    {
        public int ilcg_par_sched_seq { get; set; }
        public DateTime create_date { get; set; }
        public int? priority { get; set; }
        public DateTime CancelDate { get; set; }
        public int ilcg_par_lvl_seq { get; set; }
        public int eff_prd_seq { get; set; }
        public string ob_readonly { get; set; }
    }
}
