using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_deployment_dtl
    {
        public string subscriber_path { get; set; }
        public DateTime? last_sent_on { get; set; }
    }
}
