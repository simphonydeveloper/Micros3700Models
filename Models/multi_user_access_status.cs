using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class multi_user_access_status
    {
        public long multi_user_access_seq { get; set; }
        public string computer_name { get; set; }
        public UInt32? connection_id { get; set; }
        public DateTime? connection_time { get; set; }
        public int emp_seq { get; set; }
        public string hht_session { get; set; }
    }
}
