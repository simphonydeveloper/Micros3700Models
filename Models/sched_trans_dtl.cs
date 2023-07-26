using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class sched_trans_dtl
    {
        public int sched_seq { get; set; }
        public DateTime cnt_date { get; set; }
        public int sched_occur { get; set; }
        public int? phys_cnt_seq { get; set; }
        public int? ordr_seq { get; set; }
    }
}
