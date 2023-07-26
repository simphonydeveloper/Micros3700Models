using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_store_transport_dtl
    {
        public int store_seq { get; set; }
        public int transport_seq { get; set; }
        public string corporate_send_directory { get; set; }
        public string corporate_receive_directory { get; set; }
        public string store_send_directory { get; set; }
        public string store_receive_directory { get; set; }
        public int? last_sent_package_id { get; set; }
        public int? last_received_package_id { get; set; }
    }
}
