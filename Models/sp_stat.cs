using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class sp_stat
    {
        public string sp_name { get; set; }
        public string ob_running { get; set; }
        public DateTime? last_run_date { get; set; }
        public int? last_seq { get; set; }
        public int? connection_id { get; set; }
        public string progress { get; set; }
        public int? retries { get; set; }
    }
}
