using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class tms_reservation_limit_def
    {
        public int reservation_limit_seq { get; set; }
        public int reservation_period_seq { get; set; }
        public int rvc_seq { get; set; }
        public short day_of_week { get; set; }
        public short res_time { get; set; }
        public short cov_cnt { get; set; }
        public short acceptance_limit { get; set; }
    }
}
