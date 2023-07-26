using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class ilcg_rvc_sched_day_dtl
    {
        public int ilcg_rvc_sched_dtl_seq { get; set; }
        public int rvc_seq { get; set; }
        public int ilcg_seq { get; set; }
        public DateTime eff_date { get; set; }
        public byte eff_time { get; set; }
        public byte status { get; set; }
        public int? reassgnd_by { get; set; }
        public DateTime? reassgnd_date { get; set; }
    }
}