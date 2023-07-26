using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class tms_recent_turn_time_status
    {
        public int rvc_seq { get; set; }
        public short party_size { get; set; }
        public short? recent_turn_time { get; set; }
        public DateTime? last_refresh_date { get; set; }
    }
}
