using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_process_status
    {
        public int connection_id { get; set; }
        public string process_name { get; set; }
        public string computer_name { get; set; }
        public DateTime? start_time { get; set; }
        public DateTime? lease_expires { get; set; }
        public string process_guid { get; set; }
    }
}
