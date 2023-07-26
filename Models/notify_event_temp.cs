using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class notify_event_temp
    {
        public int notification_seq { get; set; }
        public string table_name { get; set; }
        public int primary_seq { get; set; }
        public int? secondary_seq { get; set; }
        public string action_code { get; set; }
        public DateTime? event_date { get; set; }
        public int? struct_seq { get; set; }
    }
}
