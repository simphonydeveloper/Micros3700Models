using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class tms_turn_time_def
    {
        public int turn_time_seq { get; set; }
        public int rvc_seq { get; set; }
        public int prd_seq { get; set; }
        public short cov_cnt { get; set; }
        public short? target_turn_time { get; set; }
    }
}
