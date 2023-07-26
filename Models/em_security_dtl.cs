using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_security_dtl
    {
        public int security_seq { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public int control { get; set; }
    }
}
