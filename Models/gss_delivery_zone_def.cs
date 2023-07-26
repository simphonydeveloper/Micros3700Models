using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_delivery_zone_def
    {
        public int delivery_zone_seq { get; set; }
        public string zone { get; set; }
        public string postal_code { get; set; }
        public int? expected_delivery_minutes { get; set; }
        public string street_name { get; set; }
        public string city { get; set; }
        public string state_or_province { get; set; }
        public int? start_number { get; set; }
        public int? end_number { get; set; }
        public int? street_filter_type { get; set; }
    }
}
