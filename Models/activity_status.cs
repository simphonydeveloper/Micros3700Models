using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class activity_status
    {
        public int activity_type { get; set; }
        public string origin { get; set; }
        public string status { get; set; }
        public DateTime? status_change_tm { get; set; }
        public short? expire_seconds { get; set; }
    }
}
