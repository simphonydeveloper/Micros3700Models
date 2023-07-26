using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_delivery_address_def
    {
        public int delivery_address_seq { get; set; }
        public int delivery_zone_seq { get; set; }
        public string organization_name { get; set; }
        public string premises_number { get; set; }
        public string premises_name { get; set; }
        public string unit_name { get; set; }
    }
}
