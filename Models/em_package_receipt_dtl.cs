using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_package_receipt_dtl
    {
        public int package_seq { get; set; }
        public string package_name { get; set; }
        public DateTime received_on { get; set; }
        public int? status { get; set; }
    }
}
