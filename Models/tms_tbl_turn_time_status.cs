using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class tms_tbl_turn_time_status
    {
        public int turn_time_seq { get; set; }
        public int tbl_seq { get; set; }
        public short? historic_turn_time { get; set; }
        public short? historic_turn_time_cnt { get; set; }
    }
}
