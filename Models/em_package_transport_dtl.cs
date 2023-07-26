using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_package_transport_dtl
    {
        public int package_seq { get; set; }
        public string package_name { get; set; }
        public string source_path { get; set; }
        public string destination_path { get; set; }
        public DateTime? deployed_on { get; set; }
        public DateTime? processed_on { get; set; }
        public int? status { get; set; }
        public string status_text { get; set; }
    }
}
