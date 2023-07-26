using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class table_purge_log
    {
        public int? id { get; set; }
        public string action { get; set; }
        public string description { get; set; }
        public DateTime? logged_time { get; set; }
    }
}
