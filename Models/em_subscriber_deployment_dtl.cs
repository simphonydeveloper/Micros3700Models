using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_subscriber_deployment_dtl
    {
        public string subscriber_path { get; set; }
        public DateTime deployment_date { get; set; }
        public string data_packet { get; set; }
    }
}
